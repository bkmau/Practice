using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Stock
    {
        private Unit unit;
        private int count;

        public Unit Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
