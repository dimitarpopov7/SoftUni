namespace _03.Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            string pattern= @"\b[A-Za-z][\w\d_]{2,23}\b";
            string text = Console.ReadLine();
            Regex regex = new Regex(pattern);
            var result = regex.Matches(text);
            var list = new List<string>();
            foreach (Match username in result)
            {
                list.Add(username.Value);
            }
            int startIndex = 0;
            int combinedWordsCount = 0;
            int maxCombinedWordsCount = 0;
            for (int i = 0; i < list.Count-1; i++)
            {
                combinedWordsCount = list[i].Length + list[i + 1].Length;
                if (combinedWordsCount > maxCombinedWordsCount)
                {
                    maxCombinedWordsCount = combinedWordsCount;
                    startIndex = i;
                }
            }
            for (int i = startIndex; i < startIndex+2; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
