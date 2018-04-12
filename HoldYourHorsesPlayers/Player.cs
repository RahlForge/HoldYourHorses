using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCards.Cards;

namespace HoldYourHorsesPlayers
{
    public class Player
    {
        public string Name { get; protected set; }
        public decimal Winnings { get; set; }
        private List<StandardCard> cards;

        public List<StandardCard> Cards { get { return cards; } }
        public int CardCount { get { return cards.Count; } }

        public Player(string name)
        {
            Name = name;
            cards = new List<StandardCard>();
        }

        public void ClearHand()
        {
            cards.Clear();
        }

        public void GiveCard(StandardCard card)
        {
            cards.Add(card);
        }
    }
}
