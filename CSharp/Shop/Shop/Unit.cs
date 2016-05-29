using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Unit
    {
        readonly string _name;
        readonly Unit _to;
        readonly int _carry;

        public Unit(string name, Unit to, int carry)
        {
            this._name = name;
            this._to = to;
            this._carry = carry;
        }

        public string Name
        {
            get { return _name; }
        }
        
        public Unit To
        {
            get { return _to; }
        }

        public int Carry
        {
            get { return _carry; }
        }
        
    }
}
