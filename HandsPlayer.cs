using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.HandsPlayer
{
    class HandsPlayer
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> playerCards = new Dictionary<string,List<string>>();

            string comandLine = Console.ReadLine();

            while(!comandLine.Equals("JOKER"))
            {
                string[] cammandArges = comandLine.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                string playerName = cammandArges[0];
                string[] cards = cammandArges[1]
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(c=>c.Trim()).ToArray();

                if (!playerCards.ContainsKey(playerName))
                {
                    playerCards.Add(playerName, new List<string>());
                }
                playerCards[playerName].AddRange(cards);
                

                comandLine = Console.ReadLine();
            }

            PrintPlayersScore(playerCards);

        }

        private static void PrintPlayersScore(Dictionary<string, List<string>> playerCards)
        {
            foreach (var playerEntry in playerCards)
            {
                string playrName = playerEntry.Key;
                List<string> cards = playerEntry.Value.Distinct().ToList();

                int sum = 0;
                foreach (var card in cards)
                {
                    string rank = card.Substring(0, card.Length - 1);
                    string suite = card.Substring(card.Length - 1);
                    int rankPower = GetRank(rank);
                    int suitePower = GetSuite(suite);

                    sum += rankPower * suitePower;
                 }

                Console.WriteLine("{0}: {1}", playrName, sum);
            }
        }

        private static int GetSuite(string suite)
        {
            switch(suite)
            {
                case"S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
                    break;
            }
        }

        private static int GetRank(string rank)
        {
            switch (rank)
            {
                case"2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 0; 
                    break;
            }
        }
    }
}
