namespace _4.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var sequenceOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x=>x)
                .Take(3)
                .ToList();
            Console.WriteLine(string.Join(" ",sequenceOfNumbers));
        }
    }
}
