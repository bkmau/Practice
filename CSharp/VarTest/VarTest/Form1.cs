using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num1 = 20;
            float num2 = 123456789;
            string str1 = "哈囉! ";
            string name = "Mr. White";
            DateTime birthday = DateTime.Now;

            lbl1.Text = num1.ToString();
            lbl2.Text = num2.ToString();
            lbl3.Text = str1 + name;
            lbl4.Text = birthday.ToString();

            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
