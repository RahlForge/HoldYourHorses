using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCards.Cards;

namespace PlayingCards.Decks
{
    public class PokerDeck : Deck
    {
        public PokerDeck(List<StandardSuit> excludedSuits, List<StandardRank> excludedRanks, bool hasJokers = false)
            :base()
        {
            deck = new List<Card>();

            // Cycle all standard card suits
            foreach(StandardSuit s in Enum.GetValues(typeof(StandardSuit)))
            {
                // If this suit is on the excluded list, skip it
                if (excludedSuits.IndexOf(s) >= 0)
                    continue;

                // Otherwise, cycle all ranks for that suit
                foreach(StandardRank r in Enum.GetValues(typeof(StandardRank)))
                {
                    // If this rank is excluded, skip it
                    if (excludedRanks.IndexOf(r) >= 0)
                        continue;

                    // Otherwise, add the card to the deck
                    deck.Add(new StandardCard(s, r));
                }
            }
        }
    }
}
