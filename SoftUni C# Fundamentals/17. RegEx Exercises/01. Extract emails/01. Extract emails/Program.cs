namespace _01.Extract_emails
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            string pattern = @"(-*|\.|_)\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            var entry = Console.ReadLine();
            Regex regex = new Regex(pattern,RegexOptions.IgnoreCase);
            var result = regex.Matches(entry);
            var list = new List<string>();
            foreach (Match email in result)
            {   
                if(email.Value[0]!='-'&& email.Value[0] != '_'&&email.Value[0] != '.')
                {
                    list.Add(email.Value);
                }
            }
            Console.WriteLine(string.Join("\n\r", list));
        }
    }
}