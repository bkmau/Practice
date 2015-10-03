using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Poker
{
    class Player
    {
        private int suit;
        private int point;
        private Bitmap pocket;

        public int Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public int Point
        {
            get { return point; }
            set { point = value; }
        }

        public Bitmap Pocket
        {
            set { pocket = value; }
        }

        public void Showdown(PictureBox pic)
        {
            pic.Image = this.pocket;
        }
    }
}
