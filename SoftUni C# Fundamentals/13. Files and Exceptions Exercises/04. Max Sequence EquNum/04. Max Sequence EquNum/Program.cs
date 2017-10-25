namespace _04.Max_Sequence_EquNum
{
    using System;
    using System.Linq;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            var text = File.ReadLines("./TextFile1.txt").ToList();
            string output = "./Output.txt";
            foreach (var line in text)
            {
                int[] array1 = line.Split(' ').Select(int.Parse).ToArray();
                int startIndex = 0;
                int count = 0;
                int maxRepeats = 0;
                for (int i = 0; i < array1.Length - 1; i++)
                {
                    if (array1[i] == array1[i + 1])
                    {
                        count++;
                        if (count > maxRepeats)
                        {
                            startIndex = i - count;
                            maxRepeats = count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                for (int i = startIndex + 1; i <= startIndex + maxRepeats + 1; i++)
                {
                    File.AppendAllText(output, ($"{array1[i]} "));
                }
                File.AppendAllText(output, Environment.NewLine);
            }            
        }
    }
}
