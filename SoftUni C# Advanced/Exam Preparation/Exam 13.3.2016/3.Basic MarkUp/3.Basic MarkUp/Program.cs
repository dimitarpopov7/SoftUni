namespace _3.Basic_MarkUp
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var count = 1;
            while (input!="<stop/>")
            {
                if (input.Contains("repeat"))
                {
                    var timesMatch = Regex.Match(input, @"value=""([0 - 9])""");
                    var valueMatch = Regex.Match(input, @"content=""(.+)""");
                    if (timesMatch.Success && int.Parse(timesMatch.Groups[1].Value) != 0 && valueMatch.Success)
                    {
                        for (int i = 0; i < int.Parse(timesMatch.Groups[1].Value); i++)
                        {
                            Console.WriteLine($"{count}. {valueMatch.Groups[1].Value}");
                            count++;
                        }
                    }
                }
                else if (input.Contains("inverse"))
                {
                    var valueMatch = Regex.Match(input, @"content=""(.+)""");
                    if (valueMatch.Groups[1].Value != "")
                    {
                        var sb = new StringBuilder();
                        foreach (var letter in valueMatch.Groups[1].Value)
                        {
                            if (char.IsLower(letter))
                            {
                                sb.Append(char.ToUpper(letter));
                            }
                            else
                            {
                                sb.Append(char.ToLower(letter));
                            }
                        }
                        Console.WriteLine($"{count}. {sb.ToString()}");
                        count++;
                    }                    
                }
                else if(input.Contains("reverse"))
                {
                    var valueMatch = Regex.Match(input, @"content=""(.+)""");
                    if (valueMatch.Groups[1].Value != string.Empty)
                    {
                        var wordArray = valueMatch.Groups[1].Value.ToCharArray();
                        Array.Reverse(wordArray);
                        Console.WriteLine($"{count}. {string.Join("", wordArray)}");
                        count++;
                    }                    
                }
                input = Console.ReadLine();
            }
        }
    }
}