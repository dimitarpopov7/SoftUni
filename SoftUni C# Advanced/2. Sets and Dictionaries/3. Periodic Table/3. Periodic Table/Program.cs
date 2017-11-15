namespace _3.Periodic_Table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine()
                    .Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                foreach (var element in entry)
                {
                    elements.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
