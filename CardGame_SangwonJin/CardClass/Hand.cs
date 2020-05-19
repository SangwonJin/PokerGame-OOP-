using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    public class Hand
    {
        private List<Card> _Cards;

        public Card Card(int indexer)
        {
            return _Cards[indexer];
        }

        public int Count
        {
            get
            {
                return _Cards.Count;
            }
        }
        public Hand()
        {
            _Cards = new List<Card>();
        }
        public void AddCard(Card newCard)
        {
            if (ContainsCard(newCard))
                throw new ArgumentException(newCard.FaceValue.ToString() + " of " + newCard.Suit.ToString() + " is already in hand.");
            _Cards.Add(newCard);
        }

        private bool ContainsCard(Card CardToCheck)
        {
            foreach (Card myCard in _Cards)
            {
                if (myCard.Suit == CardToCheck.Suit && myCard.FaceValue == CardToCheck.FaceValue)
                    return true;
            }
            return false;
        }

        public void RemoveCard(int index)
        {
            if (index < 0 || index > Count - 1)
                throw new ArgumentOutOfRangeException("Index out of range.");
            _Cards.RemoveAt(index);
        }

        public void RemoveCard(Card theCard)
        {
            if (ContainsCard(theCard) == false)
                throw new ArgumentException(theCard.FaceValue.ToString() + " of " + theCard.Suit.ToString() + " is not in hand.");
            _Cards.Remove(theCard);
        }

        public void RemoveCard(Suit theSuit, FaceValue theFaceValue)
        {
            for (int i = 0; i <= _Cards.Count - 1; i++)
            {
                if ((_Cards[i].Suit == theSuit) && (_Cards[i].FaceValue == theFaceValue))
                {
                    _Cards.Remove(_Cards[i]);
                    return;
                }
            }
            throw new ArgumentException(theFaceValue.ToString() + " of " + theSuit.ToString() + " is not in hand.");
        }

        public override string ToString()
        {
            Ranking theRanking = PokerRankings.GetRanking(this);

            return theRanking.HighestFaceValue.ToString() + " - " + theRanking.RankingType.ToString();
        }
    }
}
