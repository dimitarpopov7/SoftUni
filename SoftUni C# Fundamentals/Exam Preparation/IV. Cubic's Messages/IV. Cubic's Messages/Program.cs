namespace IV.Cubic_s_Messages
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            string entry = Console.ReadLine();            
            while (entry!="Over!")
            {
                int numOfChar = int.Parse(Console.ReadLine());
                var regex = new Regex($@"(^\d+)([A-Za-z]{{{numOfChar}}})([^A-Za-z]*$)");
                var match = regex.Match(entry);
                if (match.Success)
                {
                    var indexesFront = match.Groups[1].Value;
                    var code = match.Groups[2].Value;
                    var indexesBack = match.Groups[3].Value;
                    var indexes = string.Concat(indexesFront, indexesBack).Where(char.IsDigit).Select(x=>x-'0');
                    var sb = new StringBuilder();
                    foreach (var digit in indexes)
                    {
                        try
                        {
                            sb.Append(code[digit]);
                        }
                        catch (Exception)
                        {
                            sb.Append(' ');
                        }
                    }
                    string decodedMsg=sb.ToString();
                    Console.WriteLine($"{code} == {decodedMsg}");
                }                
                entry = Console.ReadLine();                
            }
        }
    }
}
