using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer
{
    public partial class Form1 : Form
    {
        int[,] arr;
        string[] obj = { "農夫", "小羊", "蔬菜", "野狼" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             *          小羊  蔬菜  野狼
             * 小羊     0      1      1
             * 蔬菜     1      0      0
             * 野狼     1      0      0
             */
            arr = new int[,] { { 0, 1, 1 }, { 1, 0, 0 }, { 1, 0, 0 } };
            lbLeft.Items.AddRange(obj);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            HowTo();
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            HowTo();
        }

        private void HowTo()
        {
            string str = "~~規則~~\r\n" +
                "1. 農夫一次只能帶小羊、蔬菜或野狼其中一樣或自己過河。\r\n" +
                "2. 農夫不在時，小羊會吃蔬菜；野狼會吃小羊。\r\n" +
                "3. 全部都過河就carry成功。\r\n";
            MessageBox.Show(str);
        }

        private void btnLtoR_Click(object sender, EventArgs e)
        {
            Cross(lbLeft, lbRight);
            GameOver(lbRight);
            GameOver(lbLeft);
        }

        private void btnRtoL_Click(object sender, EventArgs e)
        {
            Cross(lbRight, lbLeft);
            GameOver(lbLeft);
            GameOver(lbRight);
        }

        private void Cross(ListBox thisSide, ListBox crossSide)
        {
            string[] selected = new string[4];
            int i = 0;
            bool isFarmerSelected = false;
            foreach (string s in thisSide.SelectedItems)
            {
                selected[i] = s;
                i++;
                if (s.Equals("農夫"))
                {
                    isFarmerSelected = true;
                }
            }
            int selectedCount = thisSide.SelectedItems.Count; 
            if (isFarmerSelected)
            {
                if (selectedCount > 2)
                {
                    MessageBox.Show("一個農夫只能帶一樣東西過河!!");
                }
                else
                if(selectedCount > 0)
                {
                    i = 0;
                    while (i < 2)
                    {
                        if (! (selected[i] == null || selected[i].Equals("")))
                        {
                            thisSide.Items.Remove(selected[i]);
                            crossSide.Items.Add(selected[i]);
                        }
                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("需要農夫才能過河!!");
            }
            selected = null;
            thisSide.ClearSelected();
        }

        private void GameOver(ListBox listbox)
        {
            int[] together = new[] { 0, 0, 0 };
            bool isFarmerHere = false;
            int i = 0;
            foreach (string s in listbox.Items)
            {
                if (s.Equals("農夫"))
                {
                    isFarmerHere = true;
                }
                switch (s)
                {
                    case "農夫":
                        break;
                    case "小羊":
                        together[i] = 0;
                        i++;
                        break;
                    case "蔬菜":
                        together[i] = 1;
                        i++;
                        break;
                    case "野狼":
                        together[i] = 2;
                        i++;
                        break;
                }
            }

            if (isFarmerHere)
            {
                if (i == 3)
                {
                    if (listbox.Name.Equals("lbRight"))
                    {
                        MessageBox.Show("成功渡河!!");
                    }
                }                   
            }
            else
            {
                if ((i == 3) || ((i == 2) && (arr[together[0], together[1]] == 1)))
                {
                    MessageBox.Show("農夫血本無歸!!");
                    lbLeft.Items.Clear();
                    lbRight.Items.Clear();
                    lbLeft.Items.AddRange(obj);
                }
            }
        }

        
    }
}
