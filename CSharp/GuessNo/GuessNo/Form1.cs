using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNo
{
    public partial class Form1 : Form
    {
        int aim;
        int guess;
        int guess_left;
        int guess_right;
        int times;
        bool isGetAward;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            aim = r.Next(1, 101);
            times = 0;
            guess_left = 100;
            guess_right = 1;
            isGetAward = false;
            lblMsg.Text = "請輸入1~100之間的數字";
            txt.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isGetAward)
            {
                Application.Exit();
            }
            Award();
        }

        private void Award()
        {
            try
            {
                times++;
                guess = Convert.ToInt32(txt.Text);

                if ((guess > guess_left) || (guess < guess_right))
                {
                    txt.Text = "";
                    MessageBox.Show("請輸入" + guess_right + "~" + guess_left);
                }
                else
                if (guess == aim)
                {
                    lblMsg.Text = "恭喜發財! 中獎辣...一共猜了" + times + "次";
                    isGetAward = true;
                    return;
                }
                else if (guess > aim)
                {
                    guess_left = guess;
                }
                else if (guess < aim)
                {
                    guess_right = guess;
                }

                lblMsg.Text = guess_right + "~" + guess_left;
            }
            catch
            {
                lblMsg.Text = "請輸入數字或整數!!";
                txt.Text = "";
            }
            finally
            {
                txt.Focus();
                txt.SelectAll();
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (isGetAward)
                {
                    Application.Exit();
                }
                Award();
            }
        }
    }
}
