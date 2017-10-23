namespace _3.Word_Count
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {            
            string words = "quick is fault";
            //Creates a .txt file Words with the string inside
            File.WriteAllText("./Words.txt", words);
            var wordsToUse = File.ReadAllText("./Words.txt")
                .ToLower()
                .Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var textWords = File.ReadAllText("./TextFile1.txt")
                .ToLower()
                .Split(new[] {' ', '.', ',', '\'', '?', '-', '!', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, int> result = new Dictionary<string, int>();
            //Go throughout the list of words from the text and count how many times the words are repeated then record it in a dictionary
            for (int i = 0; i < wordsToUse.Count; i++)
            {
                var currentWord = wordsToUse[i];
                var currentWordCount = 0;
                for (int j = 0; j < textWords.Count; j++)
                {
                    if (textWords[j]==currentWord)
                    {
                        currentWordCount++;
                        result[currentWord] = currentWordCount;
                    }
                }
            }
            //Creates a list with the words and their count
            var sortedResult = result
                .OrderByDescending(x => x.Value)
                .Select(x=> ($"{x.Key}-{x.Value}"))
                .ToList();
            File.WriteAllLines("Output.txt", sortedResult);
        }
    }
}
