namespace _1.Odd_Lines
{
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
                if (i % 2 != 0)
                {
                    saveListLines.Add(file[i]);
                }             
            }
            foreach (var line in saveListLines)
            {
                File.WriteAllLines("NewFile1.txt",saveListLines);
            }
        }
    }
}
