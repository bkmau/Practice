using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quota
{
    public partial class Form1 : Form
    {
        string[] companys;
        double[,] profits;
        double[] total;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            companys = new string[3]{"台北總公司", "台中分公司", "台南分公司"};
            profits = new double[3, 4] { { 1000, 2000, 3000, 4000 },
              { 1500, 2500, 3500, 4500 }, { 3200, 1800, 3600, 1400 } };
            total = new double[3];

            CalcTotalProfit();

            RefreshDisplayText();
            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int companyID, seasonID;

            companyID = (cbCompany.SelectedIndex - 1);
            seasonID = (cbSeason.SelectedIndex - 1);

            try
            {
                if (companyID < 0 || seasonID < 0)
                    return;

                profits[companyID, seasonID] = double.Parse(txtProfit.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字!!");
                return;
            }

            CalcTotalProfit();

            RefreshDisplayText();
        }

        private void CalcTotalProfit()
        {
            for (int i = 0; i < 3; i++)
            {
                total[i] = 0;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    total[i] += profits[i, j];
                }
            }
        }

        private void RefreshDisplayText()
        {
            txtDisplay.Text = "";
            txtDisplay.Text = "營業處\b\b\b\b\b\b第一季\t第二季\t第三季\t第四季\t合計\r\n";

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                sb.AppendFormat("{0}\b\b{1}\t{2}\t{3}\t{4}\t{5}\r\n", companys[i], 
                    profits[i, 0], profits[i, 1], profits[i, 2], profits[i, 3], total[i]);
            }

            txtDisplay.Text += sb.ToString();
            txtDisplay.SelectionStart = txtDisplay.Text.Length;
        }
    }
}
