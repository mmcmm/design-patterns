using System.Collections.Generic;
using System.Linq;

namespace using System;
using System.Collections.Generic;

namespace Poker
{
    class Program
    {
        static readonly Dictionary<HandRanking, int> ranks = new Dictionary<HandRanking,int>();

        static void Main()
        {
            Hand[] hands = new Hand[10];
            Deck d = new Deck();
            d.Shuffle();

            for (int i = 0; i < hands.Length; i++)
            {
                hands[i] = new Hand();
            }

            for (int cardCount = 0; cardCount < 5; cardCount++)
            {
                foreach (Hand t in hands)
                {
                    t.Add(d.Deal());
                }
            }

            foreach (Hand hand in hands)
            {
                Console.WriteLine("{0} ({1})", hand.Rank, hand);
            }
        }
    }
}

{
    abstract class HandCatagorizer
    {
        public HandCatagorizer RegisterNext(HandCatagorizer next)
        {
            Next = next;
            return Next;
        }

        protected HandCatagorizer Next { get; private set; }

        public abstract HandRanking Catagorize(Hand hand);

        protected static bool HasNofKind(int n, Hand hand)
        {
            Dictionary<Value, int> seen = new Dictionary<Value, int>();

            foreach (Card c in hand.Cards)
            {
                if (seen.ContainsKey(c.Value))
                {
                    seen[c.Value]++;
                }
                else
                {
                    seen[c.Value] = 1;
                }
            }

            foreach (int count in seen.Values)
            {
                if (count == n)
                {
                    return true;
                }
            }

            return false;
        }

        protected static bool HasStraight(Hand hand)
        {
            List<Value> values = hand.Cards.Select(c => c.Value).ToList();
            values.Sort();

            int expectedValue = (int)values[0];

            foreach (Value value in values)
            {
                if ((int)value != expectedValue)
                {
                    return false;
                }

                expectedValue++;
            }

            return true;
        }

        protected static bool HasFlush(Hand hand)
        {
            List<Suit> suits = hand.Cards.Select(c => c.Suit).ToList();
            suits.Sort();

            Suit expected = suits[0];

            return suits.All(suit => suit == expected);
        }
    }
}
