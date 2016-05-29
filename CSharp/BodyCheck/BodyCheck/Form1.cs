using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BodyCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Boy_Click(object sender, EventArgs e)
        {
            txt_Weight.Text = "標準體重 : " + ((Convert.ToDouble(txt_Tall_CM.Text) - 80) * 0.7) +
                                       " 公斤";
            txt_Tall_CM.Focus();
        }

        private void btn_Girl_Click(object sender, EventArgs e)
        {
            txt_Weight.Text = "標準體重 : " + ((Convert.ToDouble(txt_Tall_CM.Text) - 70) * 0.6) +
                                        " 公斤";
            txt_Tall_CM.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(""+e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Tall_CM.MaxLength = 3;
            txt_Weight.ReadOnly = true;
            txt_Tall_CM.TabIndex = 0;
        }

        private void btn_Tran_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txt_Tall_CM.Text.Equals(""))
                {
                    txt_Tall_Inch.Text = "" + Math.Floor(Convert.ToInt32(txt_Tall_CM.Text) / 2.54 + 0.5);
                }
                else
                if (!txt_Tall_Inch.Text.Equals(""))
                {
                    txt_Tall_CM.Text = "" + Math.Floor(Convert.ToInt32(txt_Tall_Inch.Text) * 2.54 + 0.5);
                }
                else
                if ((txt_Tall_CM.Text.Equals("")) && (txt_Tall_Inch.Text.Equals("")))
                {
                    MessageBox.Show("請輸入數字");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入數字");
                txt_Tall_CM.Clear();
                txt_Tall_Inch.Clear();
                txt_Tall_CM.Focus();
            }
        }

        private void txt_Tall_Inch_KeyUp(object sender, KeyEventArgs e)
        {
            txt_Tall_CM.Text = "";
        }

        private void txt_Tall_CM_KeyUp(object sender, KeyEventArgs e)
        {
            txt_Tall_Inch.Text = "";
        }
    }
}
