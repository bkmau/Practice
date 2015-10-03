using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace Poker
{
    class Dealer
    {
        private Random RanPoint, RanSuit;
        private bool[,] card;

        public Dealer()
        {
            RanPoint = new Random();
            RanSuit = new Random();
            card = new bool[4, 13];
        }

        public void InitGame(PictureBox[] pic)
        {
            foreach (var p in pic)
            {
                p.Image = new Bitmap(@"Poker\Pokerbk.jpg");
                p.Enabled = false;
            }
            InitCardArr();
        }

        private void InitCardArr()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    card[i, j] = false;
                }
            }
        }

        public void DealCardTo(Player[] player)
        {
            int i = player.Length - 1;
            int suit = 0, point = 0;
            while(i >= 0)
            {
                suit = RanSuit.Next(1, 4);
                point = RanPoint.Next(1, 13);
                if (!card[suit, point])
                {
                    player[i].Suit = suit;
                    player[i].Point = point;
                    player[i].Pocket = new Bitmap(SetCardImg(point, suit));
                    card[suit, point] = true;
                    i--;
                }
            }
            
        }

        public string SetCardImg(int point, int suit)
        {
            switch (suit)
            {
                case 1: //梅花(Clubs)
                    return @"Poker\" + point + "c.png";
                case 2: //方塊(Diamonds)
                    return @"Poker\" + point + "d.png";
                case 3: //紅心(Hearts)
                    return @"Poker\" + point + "h.png";
                case 4: //黑桃(Spades)
                    return @"Poker\" + point + "s.png";
                default:
                    return @"";
            }
        }
        
        public int CallWinner(Player a, Player b)
        {
            int winner = 0;

            if ((a.Point == 0) || (b.Point == 0))
                return -1;

            if (a.Point > b.Point)
            {
                if (b.Point != 1)
                    winner = 1;
                else
                    winner = 2;
            }
            else if (a.Point < b.Point)
            {
                if (a.Point != 1)
                    winner = 2;
                else
                    winner = 1;
            }
            else if (a.Point == b.Point)
            {
                if (a.Suit > b.Suit)
                    winner = 1;
                else
                    winner = 2;
            }
            return winner;
        }
    }
}
