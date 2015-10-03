using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Poker
{
    public partial class Form1 : Form
    {
        private Player a, b;
        private Dealer dealer;
        private int winner;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dealer = new Dealer();
            dealer.InitGame(new PictureBox[2] { pbA, pbB });

            a = new Player();
            b = new Player();
            lbl2.Text = "按洗牌鈕開始遊戲";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dealer.InitGame(new PictureBox[2] { pbA, pbB });
            dealer.DealCardTo(new Player[2] { a, b });
            winner = dealer.CallWinner(a, b);
            btnOK.Enabled = false;
            pbA.Enabled = true;
            pbB.Enabled = true;
            lbl2.Text = "請在撲克牌上按一下選取 ..";
        }

        private void pbA_Click(object sender, EventArgs e)
        {
            EndOfGame(1);
        }

        private void pbB_Click(object sender, EventArgs e)
        {
            EndOfGame(2);
        }

        private void EndOfGame(int choice)
        {
            btnOK.Enabled = true;

            pbA.Enabled = false;
            pbB.Enabled = false;
            
            if (winner == -1)
            {
                lbl2.Text = "有Bug，請重來....";
            }
            else if (winner == choice)
            {
                a.Showdown(pbA);
                b.Showdown(pbB);
                lbl2.Text = " 你贏了 ! 按洗牌鈕 重玩 ....";
            }
            else
            {
                a.Showdown(pbA);
                b.Showdown(pbB);
                lbl2.Text = " 你輸了 !  按洗牌鈕 重玩 ....";
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }    
    }
}
