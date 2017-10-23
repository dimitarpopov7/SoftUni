namespace _4.Merge_Text_Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            var listText1 = File.ReadAllText("./TextFile1.txt")
                .Split(new char[] { ' ','\r','\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var listText2 = File.ReadAllText("./TextFile2.txt")
                .Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> combinedListTexts = listText1.Concat(listText2)
                .OrderBy(x=>x)
                .ToList();
            File.WriteAllLines("./Output.txt", combinedListTexts);
        }
    }
}
