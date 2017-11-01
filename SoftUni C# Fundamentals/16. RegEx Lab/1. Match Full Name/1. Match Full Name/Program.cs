namespace _1.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(entry);
            foreach (Match name in matches)
            {
                Console.Write($"{name.Value} ");
            }
        }
    }
}
