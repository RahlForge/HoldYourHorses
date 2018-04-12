using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards.Cards
{
    public enum StandardSuit { Club, Diamond, Heart, Spade };
    public enum StandardRank { Ace=1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    public class StandardCard : Card
    {
        public StandardSuit suit { get; protected set; }
        public StandardRank rank { get; protected set; }
        public bool IsWild { get; set; }

        public StandardCard(StandardSuit suit, StandardRank rank, bool isWild = false)
            :base()
        {
            this.suit = suit;
            this.rank = rank;
            IsWild = isWild;
        }
    }
}
