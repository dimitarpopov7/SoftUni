namespace _05.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var cardPowers = GetCardPowers();
            var cardType = GetCardType();
            var playersPlusCards = new Dictionary<string, HashSet<int>>();
            while (true)
            {
                List<string> entry = Console.ReadLine().Split(':').ToList();
                char[] delimiters = new char[] { ' ', ',' };
                string name = entry[0];
                if (name == "JOKER")
                {
                    break;
                }
                List<string> cards = entry[1].Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var card in cards)
                {
                    var cardPower = card.Substring(0, card.Length-1);
                    var typeCard = card.Substring(card.Length-1);
                    var sumOfCard = cardPowers[cardPower]*cardType[typeCard];
                    if (!playersPlusCards.ContainsKey(name))
                    {
                        playersPlusCards[name] = new HashSet<int>();
                    }
                    playersPlusCards[name].Add(sumOfCard);
                }                
            }
            foreach (var item in playersPlusCards)
            {
                var playerName = item.Key;
                var score = item.Value.Sum();
                Console.WriteLine($"{playerName}: {score}");
            }
        }
        private static Dictionary<string,int> GetCardType()
        {
            var CardType = new Dictionary<string, int>();
            CardType["S"] = 4;
            CardType["H"] = 3;
            CardType["D"] = 2;
            CardType["C"] = 1;
            return CardType;
        }
        private static Dictionary<string,int> GetCardPowers()
        {
            var CardPowers=new Dictionary<string,int>();
            for (int i = 2; i <= 10; i++)
            {
                CardPowers[i.ToString()] = i;
            }
            CardPowers["J"] = 11;
            CardPowers["Q"] = 12;
            CardPowers["K"] = 13;
            CardPowers["A"] = 14;
            return CardPowers;
        }
    }
}
