namespace _3.Series_of_Letters
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            //my noobie way
            var pattern = @"([A-Za-z])\1*";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);
            foreach (Match letter in matches)
            {
                Console.Write(letter.Groups[1]);
            }
            Console.WriteLine();
            //another way
            var result1 = Regex.Replace(text, @"([A-Za-z])\1+", m => m.Groups[1].Value); // Both variations work Identically
            var result2 = Regex.Replace(text, @"([A-Za-z])\1+", "$1"); // Both variations work Identically
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
