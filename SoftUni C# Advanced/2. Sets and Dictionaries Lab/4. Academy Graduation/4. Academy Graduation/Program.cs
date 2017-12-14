namespace _4.Academy_Graduation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var marks =Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                result[name] = marks.Average();
            }
            foreach (var person in result)
            {
                Console.WriteLine($"{person.Key} is graduated with {person.Value}");
            }
        }
    }
}
