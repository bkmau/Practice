using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEventTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Load  event occurs...";
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Text = "Active event occurs...";
            this.BackColor = Color.Orange;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "A Click event occurs...";
            this.BackColor = Color.Green;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = "A DoubleClick event occurs...";
            this.BackColor = Color.Gray;
        }
    }
}
