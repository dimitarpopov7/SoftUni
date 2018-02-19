namespace _2.Card_Rank
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            var ranks = Enum.GetValues(typeof(CardRanks));
            int counter = 0;
            Console.ReadLine();
            Console.WriteLine("Card Ranks:");
            foreach (var rank in ranks)
            {
                Console.WriteLine($"Ordinal value: {counter}; Name value: {rank}");
                counter++;
            }
        }
    }
    public enum CardRanks
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
}
