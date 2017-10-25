namespace _05.Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var text = File.ReadLines("./TextFile1.txt").ToList();
            string output = "./Output.txt";
            Dictionary<string, int> commodities = new Dictionary<string, int>();
            for (int i = 0; i < text.Count; i=i+2)
            {

                string commodity = text[i];
                if (text[i] == "stop")
                {
                    break;
                }
                else
                {
                    if (!commodities.ContainsKey(text[i]))
                    {
                        commodities[text[i]] = Convert.ToInt32(text[i + 1]);
                    }
                    else
                    {
                        commodities[commodity] += Convert.ToInt32(text[i + 1]);
                    }
                }
            }
            foreach (var item in commodities)
            {
                File.AppendAllText(output,$"{item.Key} -> {item.Value}");
                File.AppendAllText(output, Environment.NewLine);
            }
        }
    }
}
