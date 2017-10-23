namespace _2.Line_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            var file = File.ReadAllLines("./File1.txt");
            var saveListLines = new List<string>();
            for (int i = 0; i < file.Length; i++)
            {
                File.AppendAllText("./NewFile.txt", ($"{i+1}. {file[i]}")  + Environment.NewLine);
            }
        }
    }
}
