using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class Form1 : Form
    {
        int no;
        DateTime start;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            no = 0;
            //設定載入的圖片和表單設計器上的PictureBox一樣大小
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = images.Images[no];

            // 設定timer每0.05秒執行Tick事件一次
            timer.Interval = 80; 
            lbl2.Text = "";
            btnStop.Enabled = false;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            start = DateTime.Now;
            btnRun.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            lbl2.Text = "一共跑了 " + 
                Math.Ceiling((DateTime.Now - start).TotalSeconds).ToString() + " 秒";
            btnRun.Enabled = true;
            btnStop.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (no < 4)
            {
                pic.Image = images.Images[no];
                no++;
            }
            else
            {
                no = 0;
            }
        }
    }
}
