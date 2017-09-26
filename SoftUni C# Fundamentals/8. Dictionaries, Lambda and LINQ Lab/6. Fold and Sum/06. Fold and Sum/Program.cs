namespace _06.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int k = numbers.Count / 4;
            var leftNums = numbers.Take(k).Reverse().ToList();
            var rightNums = numbers.Skip(3 * k).Reverse().ToList();
            var topNums = leftNums.Concat(rightNums).ToList();
            var bottomNums = numbers.Skip(k).Take(k*2).ToList();
            var result = new List<int>();
            for (int i = 0; i < topNums.Count; i++)
            {
                result.Add(topNums[i] + bottomNums[i]);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
