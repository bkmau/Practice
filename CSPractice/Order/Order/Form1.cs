using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblToal.Text = "" + (GetMainCource() + GetSides());
        }

        private int GetMainCource()
        {
            if (radioBtn_Chicken.Checked)
            {
                return 100;
            }
            else if (radioBtn_Fish.Checked)
            {
                return 99;
            }
            else if (radioBtn_Nugget.Checked)
            {
                return 110;
            }
            else
            {
                return 0;
            }
        }

        private int GetSides()
        {
            int result = 0;
            if (cb_Coke.Checked)
            {
                result += 20;
            }

            if (cb_FrenchFries.Checked)
            {
                result += 30;
            }

            if (cb_CornChowder.Checked)
            {
                result += 40;
            }
            return result;
        }
    }
}
