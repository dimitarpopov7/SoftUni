namespace _05.Magic_exchangeable_words
{
    using System;
    using System.Linq;
    namespace _05.Magic_exchangeable_words
    {
        public class Program
        {
            public static void Main()
            {
                var input = Console.ReadLine().Split();
                var fWord = input[0].Distinct().ToList();
                var sWord = input[1].Distinct().ToList();
                bool decision = false;
                if (fWord.Count == sWord.Count())
                {
                    decision = true;
                }
                if (decision)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}

