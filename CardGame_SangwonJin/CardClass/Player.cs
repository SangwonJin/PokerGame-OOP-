using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    public class Player
    {

        private string _Name;

        private float _Money;

        private string _Image;

        private float _BettingAmount;

        private bool _BetStatus = false;

        private Action _Action;

        public float Money
        {
            get
            {
                return _Money;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }
        }

        public string Image
        {
            get
            {
                return _Image;
            }
        }

        public float BettingAmount
        {
            get
            {
                return _BettingAmount;
            }
        }

        public Action Action
        {
            get
            {
                return _Action;
            }
        }

        public bool BetStatus
        {
            get
            {
                return _BetStatus;
            }
            set
            {
                _BetStatus = value;
            }
        }

        public Hand Hand { get; set; }

        public event NoMoreMOneyEventHandler NoMoreMoney;
        public delegate void NoMoreMOneyEventHandler(object sender, System.EventArgs e);

        public Player(string playerName, float playerMoney, string playerImage = "")
        {
            _Name = playerName;
            _Money = playerMoney;
            _Image = playerImage;
            Hand = new Hand();
        }

        public void WinMoney(float amount)
        {
            if ((Validate.ValidatePositive(amount) == false))
            {
                throw new ArgumentException("Amount must be positive");
            }

            _Money = (_Money + amount);
        }

        public bool BetMoney(float amount, Action actionType = Action.Bet)
        {
           
            if ((Validate.ValidatePositive(amount) == false))
            {
                throw new ArgumentException("Amount must be positive");
                // Warning!!! Optional parameters not supported
            }

            if ((BetStatus == true))
            {
                return false;
            }

            _Money = (_Money - amount);
            _BettingAmount = amount;
            _Action = actionType;
            if ((actionType != Action.PutAnte))
            {
                BetStatus = true;
            }

            if ((_Money < 0))
            {
                NoMoreMoney(this, EventArgs.Empty);
            }

            return true;
        }
    }
}
