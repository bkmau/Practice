using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Former
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            HowTo();
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            HowTo();
        }

        private void HowTo()
        {
            string str = "~~規則~~\r\n" +
                "1. 農夫一次只能帶小羊、蔬菜或野狼其中一樣或自己過河。\r\n" +
                "2. 農夫不在時，小羊會吃蔬菜；野狼會吃小羊。\r\n" +
                "3. 全部都過河就carry成功。\r\n";
            MessageBox.Show(str);
        }

        private void btnLtoR_Click(object sender, EventArgs e)
        {

        }

        private void btnRtoL_Click(object sender, EventArgs e)
        {

        }

        private void Carry()
        {
            
        }
    }
}
