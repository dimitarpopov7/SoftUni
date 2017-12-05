namespace _03.Jedi_Code_X
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(Console.ReadLine());
            }
            var text = sb.ToString();
            var nameFilter = Console.ReadLine();
            var msgFilter = Console.ReadLine();
            
            var nameRegex = new Regex($@"{Regex.Escape(nameFilter)}([A-Za-z]{{{nameFilter.Length}}})(?![A-Za-z])");
            var msgRegex = new Regex($@"{Regex.Escape(msgFilter)}([A-Za-z0-9]{{{msgFilter.Length}}})(?![A-Za-z0-9])");
            var namesMatches = nameRegex.Matches(text);
            var msgMatches = msgRegex.Matches(text);

            var listJedies = new List<string>();
            var listMsgs = new List<string>();
            foreach (Match name in namesMatches)
            {
                listJedies.Add(name.Groups[1].ToString());
            }
            foreach (Match msg in msgMatches)
            {
                listMsgs.Add(msg.Groups[1].ToString());
            }
            var msgIndexes = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < listJedies.Count; i++)
            {
                try
                {
                    Console.WriteLine($"{listJedies[i]} - {listMsgs[msgIndexes[i] - 1]}");
                }
                catch (Exception)
                {
                    continue;  
                }                
            }
        }
    }
}
