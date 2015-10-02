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
        private Random RanPoint, RanSuit;
        private int PointA, SuitA;
        private int PointB, SuitB;
        private string CardA, CardB;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CardA = @"Poker\Pokerbk.jpg";
            CardB = @"Poker\Pokerbk.jpg";
            CardDisplayer();
            RanPoint = new Random();
            RanSuit = new Random();
            lbl2.Text = "按洗牌鈕開始遊戲";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CardA = @"Poker\Pokerbk.jpg";
            CardB = @"Poker\Pokerbk.jpg";
            CardDisplayer();
            btnOK.Enabled = false;
            GetSuit();
            pbA.Enabled = true;
            pbB.Enabled = true;
            lbl2.Text = "請在撲克牌上按一下選取 ..";
        }

        private void pbA_Click(object sender, EventArgs e)
        {
            CardDisplayer();
            if ((PointA > PointB) || ((PointA == PointB) && (SuitA > SuitB)))
            {
                lbl2.Text = " 你贏了 ! 按洗牌鈕 重玩 ....";
            }
            else if ((PointA < PointB) || ((PointA == PointB) && (SuitA < SuitB)))
            {
                lbl2.Text = " 你輸了 !  按洗牌鈕 重玩 ....";
            }
            else if ((PointA == PointB) && (SuitA == SuitB))
            {
                lbl2.Text = " 平 手 !  按洗牌鈕 重玩 ....";
            }
            btnOK.Enabled = true;
        }

        private void pbB_Click(object sender, EventArgs e)
        {
            CardDisplayer();
            if ((PointA < PointB) || ((PointA == PointB) && (SuitA < SuitB)))
            {
                lbl2.Text = " 你贏了 ! 按洗牌鈕 重玩 ....";
            }
            else if ((PointA > PointB) || ((PointA == PointB) && (SuitA > SuitB)))
            {
                lbl2.Text = " 你輸了 !  按洗牌鈕 重玩 ....";
            }
            else if ((PointA == PointB) && (SuitA == SuitB))
            {
                lbl2.Text = " 平 手 !  按洗牌鈕 重玩 ....";
            }
            btnOK.Enabled = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CardDisplayer()
        {
            pbA.Enabled = false;
            try
            {
                pbA.Image = new Bitmap(CardA);
            }
            catch (Exception e)
            {
                MessageBox.Show("Poker image not exit!!\r\nPath:" +
                    CardA + "\r\n" + e.StackTrace);
                return;
            }

            pbB.Enabled = false;
            try
            {
                pbB.Image = new Bitmap(CardB);
            }
            catch (Exception e)
            {
                MessageBox.Show("Poker image not exit!!\r\nPath:" +
                    CardB + "\r\n" + e.StackTrace);
                return;
            }
        }

        private void GetSuit()
        {
            PointA = RanPoint.Next(1,13);
            SuitA = RanSuit.Next(1,4);

            switch (SuitA)
            {
                case 1:
                    CardA = @"Poker\" + PointA + "c.png";
                    break;
                case 2:
                    CardA = @"Poker\" + PointA + "d.png";
                    break;
                case 3:
                    CardA = @"Poker\" + PointA + "h.png";
                    break;
                case 4:
                    CardA = @"Poker\" + PointA + "s.png";
                    break;
                default:
                    CardA = "Error";
                    return;
            }

            PointB = RanPoint.Next(1, 13);
            SuitB = RanSuit.Next(1, 4);
            switch (SuitB)
            {
                case 1:
                    CardB = @"Poker\" + PointB + "c.png";
                    break;
                case 2:
                    CardB = @"Poker\" + PointB + "d.png";
                    break;
                case 3:
                    CardB = @"Poker\" + PointB + "h.png";
                    break;
                case 4:
                    CardB = @"Poker\" + PointB + "s.png";
                    break;
                default:
                    CardB = "Error";
                    return;
            }
        }
    }
}
