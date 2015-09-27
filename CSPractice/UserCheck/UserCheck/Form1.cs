using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace UserCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_VB_Click(object sender, EventArgs e)
        {
            lblResult.Text = Interaction.InputBox("請輸入居住城市", "居住地", "公園");
        }

        private void btn_CS_Click(object sender, EventArgs e)
        {
            lblResult.Text  = InputBox.Show("請輸入居住城市", "居住地", "公園");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Mess
        }
    }
}
