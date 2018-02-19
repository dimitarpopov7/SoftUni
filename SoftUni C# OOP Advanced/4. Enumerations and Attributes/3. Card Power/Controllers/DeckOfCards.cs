namespace _3.Card_Power.Controllers
{
    using System;
    using Enums;
    using System.Linq;
    using System.Collections.Generic;

    public class DeckOfCards
    {
        public void Run()
        {
            Console.ReadLine();
            var ranks = Enum.GetNames(typeof(Rank));
            var listOfSuits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            for (int i = 0; i < listOfSuits.Count; i++)
            {
                Console.WriteLine($"Ace of {listOfSuits[i]}");
                foreach (var rank in ranks.Take(ranks.Length - 1))
                {
                    Console.WriteLine($"{rank} of {listOfSuits[i]}");
                }
            }

        }
    }
}