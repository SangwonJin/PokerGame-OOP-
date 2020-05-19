using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClass
{
    static public class PokerRankings
    {


        private static bool hasFlush(Hand theHand)
        {
            Suit mySuit = theHand.Card(0).Suit;
            for (int i = 1; i <= theHand.Count - 1; i++)
            {
                if (mySuit != theHand.Card(i).Suit)
                    return false;
            }
            return true;
        }


        public static Ranking GetRanking(Hand theHand)
        {
            if (theHand.Count < 2)
            {
                throw new ArgumentException("Number of the cards in a hand must be >= 2 to decide the ranking.");
            }


            Ranking theRanking;
            theRanking.RankingType = null;
            theRanking.HighestFaceValue = null;

            int[] intFaceValues = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i <= theHand.Count - 1; i++)
            {
                if (theHand.Card(i).Status == Status.FaceUp)
                    intFaceValues[System.Convert.ToInt32(theHand.Card(i).FaceValue) + 1] += 1;
            }

            bool blnStraight = false, blnFlush = false, blnFourOfKind = false, blnThreeOfKind = false, blnTwoPairs = false, blnPair = false;
            FaceValue highestFaceValue = FaceValue.Two;

            if (theHand.Count == 5)
            {
                if (intFaceValues[1] == 1 && intFaceValues[10] == 1 && intFaceValues[11] == 1 && intFaceValues[12] == 1 && intFaceValues[13] == 1)
                {
                    blnStraight = true;
                    highestFaceValue = FaceValue.Ace;
                }
                else
                    for (int i = 1; i <= 9; i++)
                    {
                        if (intFaceValues[i] == 1 && intFaceValues[i + 1] == 1 && intFaceValues[i + 2] == 1 && intFaceValues[i + 3] == 1 && intFaceValues[i + 4] == 1)
                        {
                            blnStraight = true;
                            highestFaceValue = (FaceValue)i + 4 - 1;
                            break;
                        }
                    }
                blnFlush = hasFlush(theHand);
            }


            if (blnStraight == true && blnFlush == true)
            {
                if (highestFaceValue == FaceValue.Ace)
                    theRanking.RankingType = RankingType.RoyalFlush;
                else
                    theRanking.RankingType = RankingType.StraightFlush;
                theRanking.HighestFaceValue = highestFaceValue;
            }
            else if (blnFlush == true)
            {
                theRanking.RankingType = RankingType.Flush;
                for (int i = 2; i <= 13; i++)
                {
                    if (intFaceValues[i] == 1)
                        theRanking.HighestFaceValue = (FaceValue)i - 1;
                }
                if (intFaceValues[1] == 1)
                    theRanking.HighestFaceValue = FaceValue.Ace;
            }
            else if (blnStraight == true)
            {
                theRanking.RankingType = RankingType.Straight;
                theRanking.HighestFaceValue = highestFaceValue;
            }
            else
            {
                for (int i = 1; i <= 13; i++)
                {
                    if (intFaceValues[i] == 4)
                    {
                        blnFourOfKind = true;
                        highestFaceValue = (FaceValue)i - 1;
                        break;
                    }
                    else if (intFaceValues[i] == 3)
                    {
                        blnThreeOfKind = true;
                        highestFaceValue = (FaceValue)i - 1;
                    }
                    else if (intFaceValues[i] == 2)
                    {
                        if (blnPair == true)
                        {
                            blnTwoPairs = true;
                            blnPair = false;
                            if (i > System.Convert.ToInt32(highestFaceValue) && highestFaceValue != FaceValue.Ace)
                                highestFaceValue = (FaceValue)i - 1;
                        }
                        else
                        {
                            blnPair = true;
                            if (blnThreeOfKind == false && highestFaceValue != FaceValue.Ace)
                                highestFaceValue = (FaceValue)i - 1;
                        }
                    }
                }

                theRanking.HighestFaceValue = highestFaceValue;
                if (blnFourOfKind)
                    theRanking.RankingType = RankingType.FourOfKind;
                else if (blnThreeOfKind && blnPair)
                    theRanking.RankingType = RankingType.FullHouse;
                else if (blnThreeOfKind)
                    theRanking.RankingType = RankingType.ThreeOfKind;
                else if (blnTwoPairs)
                    theRanking.RankingType = RankingType.TwoPairs;
                else if (blnPair)
                    theRanking.RankingType = RankingType.Pair;
                else
                {
                    theRanking.RankingType = RankingType.HighCard;
                    for (int i = 2; i <= 13; i++)
                    {
                        if (intFaceValues[i] == 1)
                            theRanking.HighestFaceValue = (FaceValue)i - 1;
                    }
                    if (intFaceValues[1] == 1)
                        theRanking.HighestFaceValue = FaceValue.Ace;
                }
            }

            return theRanking;
        }
    }
}
