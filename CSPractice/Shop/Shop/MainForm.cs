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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Cashier c = new Cashier();
            c.ShowDialog();
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            Warehouse p = new Warehouse();
            p.ShowDialog();
        }        
    }
}
