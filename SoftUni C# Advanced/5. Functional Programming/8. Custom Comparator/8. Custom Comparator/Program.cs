namespace _8.Custom_Comparator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Action<List<int>> comparator = Actions;
            comparator(numbers);
        }

        private static void Actions(List<int> numbers)
        {
            var evenNums = new List<int>(numbers.Where(x => x % 2 == 0));
            var oddNums = new List<int>(numbers.Where(x => x % 2 != 0));
            evenNums.Sort();
            oddNums.Sort();
            var newList = evenNums.Concat(oddNums);
            Console.WriteLine(string.Join(" ",newList));
        }
    }
}
