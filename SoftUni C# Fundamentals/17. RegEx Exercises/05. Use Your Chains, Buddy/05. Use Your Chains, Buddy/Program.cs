namespace _05.Use_Your_Chains__Buddy
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            //Allows the Console to read larger lines
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string text = Console.ReadLine();
            //Take everything between <p> and </p>
            string pattern = @"<p>(.+?)<\/p>";
            //Captures all chars that are not lower case letters or numbers
            string removePattern = @"[^a-z0-9]";

            var regex = new Regex(pattern);
            var regex2 = new Regex(removePattern);
            var matches = regex.Matches(text);

            //Builds new string without the <p>'s and </p>'s
            StringBuilder newText = new StringBuilder();
            var list = new List<string>();
            foreach (Match line in matches)
            {
                newText.Append(line.Groups[1].Value);
            }

            string extractedText = newText.ToString();
            //Replaces Upper case letter and other symbols to " "
            var replacedText = regex2.Replace(extractedText, " ");
            //Replaces all white space to " "
            replacedText = Regex.Replace(replacedText, @"\s+", " ");
            //Decrypts each letter >>>'a' to 'm' => 'a' becomes 'n' & 'n' to 'z' => 'n' becomes 'a' and adds the converted letters to new text
            StringBuilder letterCorrection = new StringBuilder();
            foreach (char letter in replacedText)
            {
                if (letter >= 'a'&&letter<='m')
                {
                    letterCorrection.Append((char)(letter+13));
                }
                else if (letter >= 'n' && letter <= 'z')
                {
                    letterCorrection.Append((char)(letter - 13));
                }
                else
                {
                    letterCorrection.Append(letter);
                }
            }
            Console.WriteLine(letterCorrection.ToString());
        }
    }
}
