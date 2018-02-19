namespace _3.Card_Power.Controllers
{
    using System;
    using Enums;
    using Models;
    public class ReturnPower
    {
        public void Run()
        {
            Card card = GetCard();
            Console.WriteLine(card);
        }
        public static Card GetCard()
        {
            Rank cardRank = (Rank)Enum.Parse(typeof(Rank), Console.ReadLine());
            Suit cardSuit = (Suit)Enum.Parse(typeof(Suit), Console.ReadLine());
            var card = new Card(cardRank, cardSuit);
            return card;
        }
    }
    
}
