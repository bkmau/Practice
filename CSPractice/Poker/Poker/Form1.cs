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
        int numA, numB, suitsA, suitsB;
        Random r;
        string cardBK;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cardBK = @"Poker\Pokerbk.jpg";
            HideCard();

            lbl2.Text = "按洗牌鈕開始遊戲";
            r = new Random();
        }

        private string GetSuits()
        {
            int suits = r.Next(1, 4);
            int num = r.Next(1, 13);

            switch (suits)
            {
                case 1:
                    return (num + "s");
                case 2:
                    return (num + "s");
                case 3:
                    return (num + "s");
                case 4:
                    return (num + "s");
                default:
                    return "Error";
            }
        }

        private void GetPoint()
        {
            
            suitsB = r.Next(1, 4);
            numB = r.Next(1, 13);
        }

        private void HideCard()
        {
            pbA.Enabled = false;
            pbB.Enabled = false;
            try
            {
                pbA.Image = new Bitmap(cardBK);
                pbB.Image = new Bitmap(cardBK);
            }
            catch
            {
                MessageBox.Show("Poker image not exit\r\nPath:" + cardBK);
            }
        }

        private void ShowCard(int suit, int point)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            HideCard();
            btnOK.Enabled = false;
            GetSuits();
            GetPoint();
            lbl2.Text = "請在撲克牌上按一下選取 ..";
        }

        private void pbA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello, game a");
        }

        private void pbB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello, game b");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
