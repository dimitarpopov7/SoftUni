namespace _3.Text_filter
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToList();
            var text = Console.ReadLine();
            foreach (var bannedWord in bannedWords)
            {
                text = text.Replace(bannedWord, new string('*', bannedWord.Length));                
            }
            Console.WriteLine(text);            
        }
    }
}
