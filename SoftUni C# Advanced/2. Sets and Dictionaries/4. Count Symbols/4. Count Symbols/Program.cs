namespace _4.Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var lettersCount = new Dictionary<char, int>();
            for (int i = 0; i < line.Length; i++)
            {
                char currentLetter = line[i];
                if (!lettersCount.ContainsKey(currentLetter))
                {
                    lettersCount[currentLetter] = 1;
                }
                else
                {
                    lettersCount[currentLetter]++;
                }
            }
            foreach (var letter in lettersCount.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
