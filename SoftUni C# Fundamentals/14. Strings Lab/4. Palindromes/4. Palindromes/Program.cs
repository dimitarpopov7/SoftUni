namespace _4.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ' ', '!', ',', '?', '.','/','\\','-','"' },StringSplitOptions.RemoveEmptyEntries).ToList();
            var list = new List<string>();
            foreach (var word in text)
            {
                var newWord = word.ToCharArray();
                Array.Reverse(newWord);
                string newWordConvert = new string(newWord);
                if (newWordConvert == word)
                {
                    list.Add(Convert.ToString(word));
                }
            }
            list.Sort();
            var hs = new HashSet<string>(list);//another way to remove duplicates
            Console.Write(string.Join(", ",hs));
            Console.WriteLine();
        }        
    }
}
