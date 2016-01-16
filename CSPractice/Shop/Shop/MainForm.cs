using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;

namespace Shop
{
    public partial class MainForm : Form
    {
        private Dictionary<int, Product> products;

        public MainForm()
        {
            InitializeComponent();
            products = new Dictionary<int, Product>();
            GetProducts(products);
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

        private void GetProducts(Dictionary<int, Product> products)
        {
            int i = 0;
            XDocument xdoc = XDocument.Load("product.xml");
            var items = from p in xdoc.Descendants("product")
                               select new Product
                               {
                                   Name = p.Element("name").ToString()
                                   
                               };
            

           
        }
    }
}
