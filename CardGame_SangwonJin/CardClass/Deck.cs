using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    public class Deck
    {
        private List<Card> _Deck;

        public Hand DealHand(int Number)
        {
            Hand myHand = new Hand();
            if ((_Deck.Count < Number))
            {
                throw new ArgumentException("Insufficient cards left.");
            }

            for (int i = 0; (i
                        <= (Number - 1)); i++)
            {
                myHand.AddCard(_Deck[0]);
                _Deck.RemoveAt(0);
            }

            return myHand;
        }

        public Card DrawOneCard()
        {
            if ((_Deck.Count == 0))
            {
                throw new ArgumentException("No more card left.");
            }

            Card theCard = _Deck[0];
            _Deck.RemoveAt(0);
            return theCard;
        }

        private void MakeDeck()
        {
            _Deck = new List<Card>();
            for (int intSuit = 0; (intSuit <= 3); intSuit++)
            {
                for (int intFaceValue = 0; (intFaceValue <= 12); intFaceValue++)
                {
                    Card myCard = new Card(((Suit)(intSuit)), ((FaceValue)(intFaceValue)));
                    _Deck.Add(myCard);
                }

            }

        }

        public Deck()
        {
            this.MakeDeck();
        }

        public void Shuffle()
        {
            List<Card> tempDeck = new List<Card>();
            while ((_Deck.Count > 0))
            {
                Random rndIndex = new Random();
                Card theCard = _Deck[rndIndex.Next(0, _Deck.Count)];
                tempDeck.Add(theCard);
                _Deck.Remove(theCard);
            }

            _Deck = tempDeck;
        }
    }
}
