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
        private string unit;
        private double cost;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
