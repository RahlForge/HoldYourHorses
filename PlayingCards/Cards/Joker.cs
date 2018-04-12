using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards.Cards
{
    public class Joker : Card
    {
        public enum Suit { Joker };
        public enum Rank { Joker };
        public bool IsWild { get; set; }

        public Joker()
            :base()
        {

        }
    }
}
