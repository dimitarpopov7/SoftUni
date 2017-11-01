namespace _3.Replace_A_Tag
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            while (text != "end")
            {
                string pattern = @"<a href=(.*)>(.*)<\/a>";
                string replacement = @"[URL href=$1]$2[/URL]";
                string result = Regex.Replace(text,pattern, replacement);
                Console.WriteLine(result);
                text = Console.ReadLine();
            }
        }
    }
}
