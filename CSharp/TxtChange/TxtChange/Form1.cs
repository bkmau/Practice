using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTextChangedByBKMau(object sender, EventArgs e)
        {            
            try
            {
                TextBox tmp = (TextBox)sender;

                if (tmp.Text.Equals(""))
                {
                    tmp.Text = "0";
                }

                if (tmp.Name.Equals("txtQtyF"))
                {
                    lblSumF.Text = "";
                    lblSumF.Text = "" + Convert.ToInt32(txtQtyF.Text) * Convert.ToInt32(lblPriceF.Text);
                    if (txtQtyH.Text.Equals(""))
                    {
                        txtQtyH.Text = "0";
                    }
                }
                
                if (tmp.Name.Equals("txtQtyH"))
                {
                    lblSumH.Text = "";
                    lblSumH.Text = "" + Convert.ToInt32(txtQtyH.Text) * Convert.ToInt32(lblPriceH.Text);
                    if (txtQtyF.Text.Equals(""))
                    {
                        txtQtyF.Text = "0";
                    }
                }
            }
            catch (Exception)
            {
                if (lblSumF.Text.Equals(""))
                {
                    lblSumF.Text = "0";
                    txtQtyF.Text = "0";
                }

                if (lblSumH.Text.Equals(""))
                {
                    lblSumH.Text = "0";
                    txtQtyH.Text = "0";
                }
                MessageBox.Show("請輸入數字");
            }
            lblSumToal.Text = "" + (Convert.ToInt32(lblSumF.Text) + Convert.ToInt32(lblSumH.Text));
        }

        private void txtTextChangedByBook(object sender, EventArgs e)
        {
            try
            {
                int sumF, sumH, total;

                sumF = Convert.ToInt32(lblPriceF.Text) * Convert.ToInt32(txtQtyF.Text);

                sumH = Convert.ToInt32(lblPriceH.Text) * Convert.ToInt32(txtQtyH.Text);
                total = sumF + sumH;  
                lblSumF.Text = Convert.ToString(sumF);  
                lblSumH.Text = Convert.ToString(sumH);  
                lblSumToal.Text = Convert.ToString(total);         
            }
            catch
            {
                lblSumF.Text = "0";
                lblSumH.Text = "0";
                lblSumToal.Text = "0";
            }
        }

        // 全票文字方塊取得駐停焦點時執行
        private void txtQtyF_Enter(object sender, EventArgs e)
        {
            txtQtyF.Text = "";
        }
        // 半票文字方塊取得駐停焦點時執行
        private void txtQtyH_Enter(object sender, EventArgs e)
        {
            txtQtyH.Text = "";
        }
    }
}
