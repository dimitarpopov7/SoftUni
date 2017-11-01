namespace _2.Match_phone_number
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine();
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            var regex = new Regex(pattern);
            var result = regex.Matches(entry);
            var list = new List<string>();
            foreach (Match phone in result)
            {
                list.Add(phone.Value);
            }
            Console.Write(string.Join(", ", list));
        }
    }
}
