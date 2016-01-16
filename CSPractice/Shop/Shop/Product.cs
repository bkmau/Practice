using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Product
    {
        private string name;
        private List<Unit> unit;
        private Stock stock;
        private Cost cost;
        private Price price;

        public Product() { }

        public Product(string name, List<Unit> unit, Stock stock, Cost cost, Price price)
        {
            this.name = name;
            this.unit = unit;
            this.stock = stock;
            this.cost = cost;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Unit> Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public Stock Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Cost Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public Price Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
