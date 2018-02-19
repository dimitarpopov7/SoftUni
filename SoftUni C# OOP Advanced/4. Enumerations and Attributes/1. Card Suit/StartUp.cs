namespace _1.Card_Suit
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            var suits = Enum.GetValues(typeof(CardSuit));
            int counter = 0;
            Console.WriteLine("Card Suits:");
            foreach (var suit in suits)
            {
                Console.WriteLine($"Ordinal value: {counter}; Name value:{suit}");
                counter++;
            }
        }
    }
}
