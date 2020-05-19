using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    public enum FaceValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum Status
    {
        FaceUp,
        FaceDown
    }

    public enum RankingType
    {
        HighCard,
        Pair,
        TwoPairs,
        ThreeOfKind,
        Straight,
        Flush,
        FullHouse,
        FourOfKind,
        StraightFlush,
        RoyalFlush
    }

    public struct Ranking
    {
        public RankingType? RankingType;
        public FaceValue? HighestFaceValue;
    }

    public enum Action
    {
        PutAnte,
        Check,
        Bet,
        DoCall,
        Fold
    }
}
