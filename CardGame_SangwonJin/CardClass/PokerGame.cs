using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardClass
{
    public class PokerGame
    {
        private List<Player> _Players;
        private float _Pot;
        private int _BettingTurn;
        private float _BettingPerPersonThisTurn;
        private Player _Winner;

        public Deck Deck { get; set; }
        public float Ante { get; } = 1;

        public List<Player> Players
        {
            get
            {
                return _Players;
            }
        }

        public float Pot
        {
            get
            {
                return _Pot;
            }
        }

        public Player Winner
        {
            get
            {
                return _Winner;
            }
        }

        //Event Handlers
        public event BettingDoneEventHandler BettingDone;

        public delegate void BettingDoneEventHandler(object sender, System.EventArgs e);

        public event FoldDoneEventHandler FoldDone;

        public delegate void FoldDoneEventHandler(object sender, System.EventArgs e);

        public event BettingTurnFinishedEventHandler BettingTurnFinished;

        public delegate void BettingTurnFinishedEventHandler(object sender, System.EventArgs e);

        public event GameEndEventHandler GameEnd;

        public delegate void GameEndEventHandler(object sender, System.EventArgs e);

        public event PuAnteFailedEventHandler PuAnteFailed;

        public delegate void PuAnteFailedEventHandler(object sender, System.EventArgs e);

        public PokerGame()
        {
            _Players = new List<Player>();
            Deck = new Deck();
            Deck.Shuffle();
        }

        private bool ContainsPlayer(Player thePlayer)
        {
            foreach (var player in _Players)
            {
                if (player == thePlayer)
                    return true;
            }
            return false;
        }

        public void AddPlayer(Player Player)
        {
            if (ContainsPlayer(Player))
                throw new ArgumentException("The player is already playing the game.");
            if (_Players.Count == 2)
                throw new ConstraintException("The game already full in players.");
            Player.Hand = new Hand();
            Player.BetStatus = false;
            _Players.Add(Player);
        }

        public void PutAnte(Player thePlayer)
        {
            if (ContainsPlayer(thePlayer) == false)
                throw new ArgumentException("The player is not playing in this game.");
            if (thePlayer.Money < Ante)
                PuAnteFailed?.Invoke(thePlayer, EventArgs.Empty);
            thePlayer.BetMoney(Ante, Action.PutAnte);
            _Pot += Ante;
            _BettingPerPersonThisTurn = Ante;
        }

        public void Bet(Player thePlayer, float Amount, Action ActionType = Action.Bet)
        {
            if (ContainsPlayer(thePlayer) == false)
                throw new ArgumentException("The player is not playing in this game.");
            if (Amount > _Pot)
                throw new ArgumentException("Maximum Betting Amount is the amount of the pot(" + _Pot.ToString("C") + ")");
            if (Amount > thePlayer.Money)
                throw new ArgumentException(thePlayer.Name + " doesn't have enough money to bet.");
            bool blnBetResult = thePlayer.BetMoney(Amount, ActionType);
            if (blnBetResult)
            {
                _Pot += Amount;
                _BettingPerPersonThisTurn = Amount;
                BettingDone?.Invoke(thePlayer, EventArgs.Empty);
                IncreaseBettingTurn();
            }
            else
            {
                _Players.Remove(thePlayer);
                DecideWinner();
            }
        }

        public void Check(Player thePlayer)
        {
            Bet(thePlayer, 0, Action.Check);
        }

        public void DoCall(Player thePlayer)
        {
            Bet(thePlayer, _BettingPerPersonThisTurn, Action.DoCall);
        }

        public void Fold(Player thePlayer)
        {
            if (ContainsPlayer(thePlayer) == false)
                throw new ArgumentException("The player is not playing in this game.");
            _Players.Remove(thePlayer);
            FoldDone?.Invoke(thePlayer, EventArgs.Empty);
            DecideWinner();
        }

        private void IncreaseBettingTurn()
        {
            bool blnBettingFinished = true;
            foreach (Player thePlayer in _Players)
            {
                if (thePlayer.BetStatus == false)
                    blnBettingFinished = false;
            }

            if (blnBettingFinished == true)
            {
                _BettingTurn += 1;

                if (_BettingTurn == 4)
                {
                    foreach (Player thePlayer in _Players)
                    {
                        for (int i = 0; i <= thePlayer.Hand.Count - 1; i++)
                            thePlayer.Hand.Card(i).ChangeStatus(Status.FaceUp);
                    }
                    DecideWinner();
                }
                else
                {
                    foreach (Player thePlayer in _Players)
                        thePlayer.BetStatus = false;
                    BettingTurnFinished?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public void DecideWinner()
        {
            if (_Players.Count != 1)
            {
                foreach (Player player in _Players)
                {
                    if (player.Hand.Count < 5)
                        throw new ConstraintException("Game is in process.");
                }
            }
            _Winner = GetTopRanking();
            _Winner.WinMoney(_Pot);
            _Pot = 0;
            GameEnd?.Invoke(this, EventArgs.Empty);
        }

        public Player DecideBetterHandPlayer()
        {
            return GetTopRanking();
        }

        private Player GetTopRanking()
        {
            if (_Players.Count == 0)
                throw new ArgumentException("No player in the game.");
            Player Winner = _Players[0];
            Ranking topRanking;
            topRanking.RankingType = RankingType.HighCard;
            topRanking.HighestFaceValue = FaceValue.Two;
            foreach (Player player in _Players)
            {
                Ranking theRanking = PokerRankings.GetRanking(player.Hand);
                if (theRanking.RankingType > topRanking.RankingType)
                {
                    topRanking.RankingType = theRanking.RankingType;
                    topRanking.HighestFaceValue = theRanking.HighestFaceValue;
                    Winner = player;
                }
                else if (theRanking.RankingType == topRanking.RankingType)
                {
                    if (theRanking.HighestFaceValue == FaceValue.Ace)
                    {
                        topRanking.RankingType = theRanking.RankingType;
                        topRanking.HighestFaceValue = theRanking.HighestFaceValue;
                        Winner = player;
                    }
                    else if (theRanking.HighestFaceValue != FaceValue.Ace && topRanking.HighestFaceValue != FaceValue.Ace && theRanking.HighestFaceValue > topRanking.HighestFaceValue)
                    {
                        topRanking.RankingType = theRanking.RankingType;
                        topRanking.HighestFaceValue = theRanking.HighestFaceValue;
                        Winner = player;
                    }
                }
            }
            return Winner;
        }
    }
}
