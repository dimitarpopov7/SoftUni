namespace _02.Extract_sentences_by_keyword
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            var text = Console.ReadLine();
            string pattern = $@"[^.!?;]*(({word}\s)|(\s{word}\s))[^.!?;]*";
            Regex regex = new Regex(pattern);
            var sentences = regex.Matches(text);
            List<string> list = new List<string>();
            foreach (Match sentence in sentences)
            {
                list.Add(sentence.Value);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
