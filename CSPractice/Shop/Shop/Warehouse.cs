using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            lblUnit_1.Text = "";

            txtUnit_2.Visible = false;
            lblUnit_2.Visible = false;

            lblCostUnit.Text = "";
            lblPriceUnit.Text = "";
        }
    }
}
