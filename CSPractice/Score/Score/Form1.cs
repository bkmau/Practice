using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score
{
    public partial class Form1 : Form
    {
        string[] stuName;
        int[] stuScore;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stuName = new string[] { "趙一", "林二", "張三", "李四", "王五", "孫六" };
            stuScore = new int[] { 75, 56, 40, 26, 85, 90 };
            lblDisp.Text = "";
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            lblDisp.Text = "\b\b\b姓名\b\b\b成績\r\n";
            DisplayData("\b{0}\b{1}\b\b\b{2}\r\n", stuName, stuScore);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string[] nameTemp = new string[6];
            stuName.CopyTo(nameTemp, 0);

            int[] scoreTemp = new int[6];
            stuScore.CopyTo(scoreTemp, 0);

            Array.Sort(scoreTemp, nameTemp);

            Array.Reverse(nameTemp);
            Array.Reverse(scoreTemp);

            
            lblDisp.Text = "\b\b\b姓名\b\b\b成績\b\b\b排名\r\n";
            DisplayData("\b{0}\b{1}\b\b\b{2}\b\b\b\b\b{3}\r\n", nameTemp, scoreTemp);
        }

        private int DisplayData(string format, string[] name, int[] score)
        {
            /*
            * 有關array長度的方法和屬性
            * 1. array.Rank -> 取得array的維度(dimensions)
            * 2. array.Length -> 取得array陣列元素的數量
            *    ex. 
            *      int[] arr = new int[3] { 1, 2, 3 }; //arr.Length = 3; 
            *      int[,] arr = new int[2, 2] { { 2, 3 }, { 4, 5 } }; //arr.Length = 4; 
            * 3. arr.GetLength(dimension) -> 取得array的指定維度(dimension)的長度
            * 4. arr.GetLowerBound(dimension) & arr.GetUpperBound(dimension)
            */
            string str = "";
            string errMsg ="";
            int count = 0;
            for (int i = 0; i < stuName.Length; i++)
            {
                str += string.Format(format, (i + 1).ToString(), name[i], score[i], 
                    (i + 1).ToString());
                if (score[i] >= 60)
                {
                    if (score[i] <= 100)
                        count++;
                    else
                        errMsg += string.Format(
                            "{0}的成績是{1}...爆表了!!不予列入合格名單....\r\n", name[i], score[i]);
                }
            }
            if (!errMsg.Equals(""))
                MessageBox.Show(errMsg);
            lblDisp.Text += str;
            return count;
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            int i = 0;
            string str = lblDisp.Text;

            lblDisp.Text = "\b\b\b姓名\b\b\b成績\r\n";
            i = DisplayData("\b{0}\b{1}\b\b\b{2}\r\n", stuName, stuScore);
            
            if (!str.Equals(""))
                lblDisp.Text = str;
            
            lblDisp.Text += "及格人數共:" + i +"人";
        }
    }
}
