using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int loan, year, month;
            double yearRate, monthRate, payRate;

            loan = 500000;
            year = 20;
            month = 20*12;
            yearRate = 0.04;
            monthRate = 0.04/12;
            payRate = (Math.Pow((1 + monthRate), month) * monthRate) / (Math.Pow((1 + monthRate), month) - 1);

            lbl2.Text += " " + loan;
            lbl3.Text += " " + yearRate*100 + "%";
            lbl4.Text += " " + year;
            lbl5.Text += " " + (int)(loan * payRate+0.5);

        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("It is simple app don't need help!!");
        }
    }
}
