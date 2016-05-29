using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl4.Text = "";
            lbl5.Text = "";
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            double income = 0;
            try
            {
                income = double.Parse(txt1.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字或小數!!");
                return;
            }

            double taxRate = (income <= 100 ? 15 : (income < 300 ? 20 : 40));
            /*
             * if (income <= 100 ) { 
             *   tax = 15; 
             * } else if (100<income<=300) { 
             *   tax = 20; 
             * } else {
             *   txt = 40; 
             * }
             */

            lbl4.Text = taxRate +" %";
            double tax = (income * taxRate / 100 * 100000);

            lbl5.Text = "" + String.Format("{0:N}", tax) + " 元";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Application.Exit();
        }
    }
}
