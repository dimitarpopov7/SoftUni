namespace _2.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();
            var wordCount = new Dictionary<string,int>();
            foreach (var word in text)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 0;
                }
                wordCount[word]++;
            }
            var result = new List<string>();
            foreach (var word in wordCount)
            {
                if (word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }            
            Console.WriteLine(string.Join(", ",result)); 
        }
    }
}
