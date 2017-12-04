namespace _12.Little_John
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(input);
                input = Console.ReadLine();
            }
            var text = sb.ToString();
            string arrowMatcher = @"(>----->)|(>>----->)|(>>>----->>)";
            var regex = new Regex(arrowMatcher);
            var matches = regex.Matches(text);
            int countSmall = 0;
            int countMedium = 0;
            int countLarge = 0;
            const string smallArrow = ">----->";
            const string mediumArrow = ">>----->";
            const string largeArrow = ">>>----->>";
            foreach (Match item in matches)
            {
                switch (item.ToString())
                {
                    case smallArrow:
                        countSmall++;
                        break;
                    case mediumArrow:
                        countMedium++;                       
                        break;
                    case largeArrow:
                        countLarge++;
                        break;
                }
            }
            int decNumber = Convert.ToInt32(string.Format($"{countSmall}{countMedium}{countLarge}"));
            var toBin = Convert.ToString(decNumber, 2).ToCharArray();
            var binFirst = new string(toBin);
            Array.Reverse(toBin);
            var binSecond = new string(toBin);
            var binCombined = $"{binFirst}{binSecond}";
            var combinedToDec = Convert.ToInt32(binCombined.ToString(), 2);;
            Console.WriteLine(combinedToDec);
        }
    }
}
