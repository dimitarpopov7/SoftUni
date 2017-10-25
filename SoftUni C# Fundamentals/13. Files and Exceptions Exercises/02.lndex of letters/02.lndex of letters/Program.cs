namespace _02.lndex_of_letters
{
    using System;
    using System.IO;
    public class Program
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("./TextFile1.txt");
            var output = "./Output.txt";
            foreach (var line in lines)
            {
                var charArray = line.ToCharArray();
                foreach (var letter in charArray)
                {                    
                    int index = Convert.ToInt32(letter)-96;
                    File.AppendAllText(output, ($"{letter}->{index}"));
                    File.AppendAllText(output, Environment.NewLine);
                }
                File.AppendAllText(output, (new string('-',20)));
                File.AppendAllText(output, Environment.NewLine);
            }
        }
    }
}
