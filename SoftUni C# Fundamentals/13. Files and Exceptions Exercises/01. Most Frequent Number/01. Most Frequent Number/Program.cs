namespace _01.Most_Frequent_Number
{
    using System;
    using System.Linq;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            var lines= File.ReadAllLines("./TextFile1.txt");
            foreach (var line in lines)
            {
                var numbersList = line.Split(' ').ToList();
                
                int count = 1;
                int maxCount = 0;
                var mostFreqNum = string.Empty;
                for (int i = 0; i < numbersList.Count-1; i++)
                {
                    var firstNum = numbersList[i];
                    for (int j = 0; j < numbersList.Count; j++)
                    {                        
                        var nextNum = numbersList[j];
                        if (firstNum == nextNum && j != i)
                        {
                            count++;                            
                        }
                    }
                    if (maxCount < count)
                    {
                        mostFreqNum = firstNum;
                        maxCount = count;
                        count = 1;
                    }
                    else
                    {
                        count = 1;
                    }
                }
                string output = "./Output.txt";
                File.AppendAllText(output, mostFreqNum);
                File.AppendAllText(output, Environment.NewLine);
            }

        }
    }
}
