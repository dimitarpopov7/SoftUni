namespace _03.Miner_Task
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {            
            Dictionary<string, int> commodities = new Dictionary<string, int>();            
            while (true)
            {
                string entry = Console.ReadLine();
                if (entry.Equals("stop"))
                {
                    break;
                }
                int value = int.Parse(Console.ReadLine());
                if (commodities.ContainsKey(entry))
                {
                    commodities[entry] += value;
                }
                else
                {
                    commodities.Add(entry, value);
                }                
            }
            foreach (var item in commodities)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
