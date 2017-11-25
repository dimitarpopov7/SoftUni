namespace _11.Semantic_HTML
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var startPattern = @"<div.*?\b((id|class)\s*=\s*""(.*?)"").*?>";
            var endPattern = @"<\/(div>\s*<!--\s*(\w*)\s*--)>";
            var newText = new List<string>();
            while (text != "END")
            {
                var regex1 = new Regex(startPattern);
                var regex2 = new Regex(endPattern);
                var matchesFirst = regex1.Matches(text);
                var matchesSecond = regex2.Matches(text);
                if (matchesFirst.Count > 0)
                {
                    foreach (Match item in matchesFirst)
                    {
                        var idClass = item.Groups[1].ToString();
                        var firstWord = item.Groups[3].ToString();
                        int indexOfChovka = text.IndexOf('<') + 1;
                        text = text.Remove(indexOfChovka, 3);
                        text = text.Insert(indexOfChovka, firstWord);
                        int indexOfEmptySpace = text.LastIndexOf(idClass) - 1;
                        text = text.Remove(indexOfEmptySpace, 1);
                        text = text.Replace(idClass, "");
                        int indexOfLastChovka = text.LastIndexOf('>') - 1;
                        if (text[indexOfLastChovka] == ' ')
                        {
                            text = text.Remove(indexOfLastChovka, 1);
                        }
                        newText.Add(text);
                    }
                }
                else if (matchesSecond.Count > 0)
                {
                    foreach (Match item in matchesSecond)
                    {
                        var lastLine = item.Groups[2].ToString();
                        var toBeChanged = item.Groups[1].ToString();
                        int indexOfNaklonena = text.IndexOf('/') + 1;
                        text = text.Replace(toBeChanged, "");
                        text = text.Insert(indexOfNaklonena, lastLine);
                        newText.Add(text);
                    }
                }
                else
                {
                    newText.Add(text);
                }
                text = Console.ReadLine();
            }
            foreach (var line in newText)
            {
                Console.WriteLine(line);
            }
        }
    }
}
