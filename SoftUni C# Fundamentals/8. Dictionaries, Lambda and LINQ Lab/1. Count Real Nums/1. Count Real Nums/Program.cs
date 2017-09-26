
namespace _1.Count_Real_Nums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers=Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            var result = new SortedDictionary<double,int>();
            foreach (var num in numbers)
            {                
                if (!result.ContainsKey(num))
                {
                    result[num] = 0;
                }                
                result[num]++;
            }
            foreach (var number in result)
            {
                Console.WriteLine($"{number.Key} -> {number.Value} times");
            }
        }
    }
}
