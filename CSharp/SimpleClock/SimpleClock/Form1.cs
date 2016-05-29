using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClock
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        private void Btn_DateTime_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void Btn_Text_Click(object sender, EventArgs e)
        {
            label1.Text = "電子鐘面板";
        }
    }
}
