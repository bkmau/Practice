using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace ScoreAvg
{
    public partial class Form1 : Form
    {
        int totalOfStu;
        int numOfStu;

        string msg_1 = @"第 {0} 位同學成績:";
        string msg_2 = @"{1}" + "\r\n";
        string msg_3 = @"加總:  {0}" + "\r\n" + @"總平均: {1}";

        int[] scoreOfStu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totalOfStu = 0;
            numOfStu = 1;
            scoreOfStu = new int[3];

            lbl1.Text = "";
            lblMsg.Text = "";
            btnInput.Enabled = true;
            btnCalAvg.Enabled = false;
            txtScore.Enabled = true;
            
            lbl1.Text = String.Format(msg_1, PadZeroToNumber(numOfStu, "000"));
        }

        private string PadZeroToNumber(int number, string format)
        {
            try
            {
                if (int.Parse(format) != 0)
                {
                    MessageBox.Show("請以0000為格式");
                    return "";
                }
            }
            catch
            {
                MessageBox.Show("請以0000為格式");
                return "";
            }

            string numStr = number.ToString();
            int neededZero = numStr.Length - format.Length;

            if (neededZero < 0)
            {
                return format.Substring(0, Math.Abs(neededZero)) + numStr;
            }
            else if (neededZero > 0)
            {
                return "";
            }
            else
            {
                return numStr;
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                int score = int.Parse(txtScore.Text);
                if (score < 100)
                {
                    scoreOfStu[totalOfStu] = score;
                    totalOfStu++;
                    btnCalAvg.Enabled = true;
                    
                    lblMsg.Text += String.Format((msg_1 + msg_2),
                        PadZeroToNumber(numOfStu, "000"), txtScore.Text);

                    if (totalOfStu < scoreOfStu.Length)
                    {
                        numOfStu++;
                        lbl1.Text = String.Format(msg_1, PadZeroToNumber(numOfStu, "000"));
                    }
                    else
                    {
                        lbl1.Text = "算平均了!!";
                        btnInput.Enabled = false;
                        txtScore.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("不適用滿分超過100的計算!!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字!!");
                return;
            }
            finally
            {
                txtScore.Text = "";
                txtScore.Focus();
            }
        }

        private void btnCalAvg_Click(object sender, EventArgs e)
        {
            lbl1.Text = "算平均了!!";
            int total = 0, avg = 0;
            
            foreach (int i in scoreOfStu)
            {
                total += i;
            }

            avg = total / totalOfStu;

            for (int i = (totalOfStu-1); i >= 0; i--)
            {
                scoreOfStu[i] = 0;
            }
            totalOfStu = 0;
            numOfStu = 1;

            btnInput.Enabled = true;
            btnCalAvg.Enabled = false;
            txtScore.Enabled = true;

            lblMsg.Text += String.Format(msg_3, total.ToString(), avg.ToString());
        }

        private void txtScore_MouseDown(object sender, MouseEventArgs e)
        {
            Regex regex = new Regex(@"([加][總])([\s\S])*(\r)?(\n)([總][平][均])", RegexOptions.Compiled);
            if (regex.IsMatch(lblMsg.Text))
            {
                lblMsg.Text = "";
                lbl1.Text = String.Format(msg_1, PadZeroToNumber(numOfStu, "000"));
            }
        }
    }
}
