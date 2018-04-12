using System;
using System.Collections.Generic;
using PlayingCards.Cards;

namespace PlayingCards.Decks
{
    public abstract class Deck
    {
        protected List<Card> deck;
        protected int nextCard;

        public Deck()
        {         
            nextCard = 0;
        }

        public void Shuffle()
        {
            List<Card> shuffledDeck = new List<Card>();
            Random random = new Random(DateTime.Now.Millisecond);
            while (deck.Count > 0)
            {
                nextCard = random.Next(deck.Count);
                shuffledDeck.Add(Deal());
                deck.RemoveAt(nextCard);
            }
            deck = shuffledDeck;
            nextCard = 0;
        }

        public Card[,] Deal(int numberOfHands, int cardsPerHand)
        {
            Card[,] cardsDealt = new Card[numberOfHands, cardsPerHand];
            for (int i = 0; i < cardsPerHand; i++)
            {
                for (int j = 0; j < numberOfHands; j++)
                {
                    cardsDealt[j, i] = deck[nextCard++];
                    if (nextCard >= deck.Count)
                        return cardsDealt;
                }
            }
            return cardsDealt;
        }

        public Card Deal()
        {
            return deck[nextCard];
        }
    }
}
