using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Price
    {
        private Unit unit;
        private double value;

        private Unit Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
