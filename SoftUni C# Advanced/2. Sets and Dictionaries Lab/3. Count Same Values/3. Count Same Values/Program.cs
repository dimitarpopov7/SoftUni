namespace _3.Count_Same_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var enter = Console.ReadLine();
            var entry = new List<double>();
            try
            {
                entry = enter.Split(new []{ " "},StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            }
            catch (Exception)
            {
                return;
            }
            var record = new SortedDictionary<double, int>();
            int count = 1;
            foreach (var item in entry)
            {
                if (!record.ContainsKey(item))
                {
                    record[item] = count;
                }
                else
                {
                    record[item]++;
                }
            }
            foreach (var num in record)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
