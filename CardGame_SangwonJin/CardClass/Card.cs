using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    public class Card
    {
        private FaceValue _FaceValue;
        private Suit _Suit;
        private Status _Status;

        public FaceValue FaceValue
        {
            get
            {
                return _FaceValue;
            }
        }

        public Suit Suit
        {
            get
            {
                return _Suit;
            }
        }

        public Status Status
        {
            get
            {
                return _Status;
            }
        }

        public Card(Suit newSuit, FaceValue newValue, Status newStatus = Status.FaceUp)
        {
            _Suit = newSuit;
            _FaceValue = newValue;
            _Status = newStatus;
        }

        public void ChangeStatus(Status theStatus)
        {
            _Status = theStatus;
        }
    }
}
