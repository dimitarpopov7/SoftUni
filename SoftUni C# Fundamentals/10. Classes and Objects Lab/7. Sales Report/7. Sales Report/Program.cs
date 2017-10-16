namespace _7.Sales_Report
{
    using System;
    using System.Collections.Generic;
  public class Program
    {
        public class TownVariables
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public double price { get; set; }
            public double quantity { get; set; }
            public double total => price * quantity;
        }
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var data = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var list = Console.ReadLine().Split(' ');
                TownVariables entry = new TownVariables
                {
                    Town=list[0],
                    Product=list[1],
                    price=double.Parse(list[2]),
                    quantity=double.Parse(list[3])
                };
                if (!data.ContainsKey(entry.Town))
                {
                    data[entry.Town] = entry.total;
                }
                else
                {
                    data[entry.Town] += entry.total;
                }
            }
            foreach (var city in data)
            {
                Console.WriteLine($"{city.Key} -> {city.Value:f2}");
            }
        }
    }
}
