namespace _07.Advertisement_Message
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            string output = "./Output.txt";
            List<string> phrases = new List<string>
            {
               "Excellent product.",
               "Such a great product.",
               "I always use that product.",
               "Best product of its category.",
               "Exceptional product.",
               "I can’t live without this product."
            };
            List<string> events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> authors = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            List<string> cities = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            int n = int.Parse(Console.ReadLine());
            Random rnd1 = new Random();
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                {
                    File.AppendAllText(output, ($"{phrases[rnd1.Next(0, phrases.Count)]} {events[rnd1.Next(0, events.Count)]} {authors[rnd1.Next(0, authors.Count)]} – {cities[rnd1.Next(0, cities.Count)]}."));
                    File.AppendAllText(output, Environment.NewLine);
                    File.AppendAllText(output, new string('-', 10));
                    File.AppendAllText(output, Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(output, ($"{phrases[rnd1.Next(0, phrases.Count)]} {events[rnd1.Next(0, events.Count)]} {authors[rnd1.Next(0, authors.Count)]} – {cities[rnd1.Next(0, cities.Count)]}."));
                }
                
            }
        }
    }
}
