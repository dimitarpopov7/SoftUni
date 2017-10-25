namespace _03.Equal_Sums
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
                var numbers = line.Split(' ').Select(int.Parse).ToArray();
                int leftSum = 0;
                int rightSum = 0;
                if (numbers.Length == 1)
                {
                    File.AppendAllText(output, "0");
                    File.AppendAllText(output, Environment.NewLine);
                }
                else
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        for (int left = 0; left < i; left++)
                        {
                            leftSum += numbers[left];
                        }
                        for (int right = numbers.Length - 1; right > i; right--)
                        {
                            rightSum += numbers[right];
                        }
                        if (leftSum == rightSum)
                        {
                            string index = Convert.ToString(i);
                            File.AppendAllText(output, index);
                            File.AppendAllText(output, Environment.NewLine);
                            goto start;
                        }
                        leftSum = 0;
                        rightSum = 0;
                    }
                    File.AppendAllText(output, "no");
                    File.AppendAllText(output, Environment.NewLine);
                }
                start:;
                File.AppendAllText(output, new string('-',20));
                File.AppendAllText(output, Environment.NewLine);
            }
        }
    }
}
