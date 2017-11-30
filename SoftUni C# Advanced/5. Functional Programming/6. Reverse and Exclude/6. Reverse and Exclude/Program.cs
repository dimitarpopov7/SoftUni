namespace _6.Reverse_and_Exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Reverse();
            int number = int.Parse(Console.ReadLine());
            Func<List<int>, int, List<int>> newList=Adjust;
            var listToPrint = newList(numbers,number);
            Console.WriteLine(string.Join(" ",listToPrint));

            //Shorter Approach
            //Func<int, bool> condition = x => x % number != 0;
            //var returnedNumbers = numbers.Where(condition);
            //Console.WriteLine(string.Join(" ",returnedNumbers));
        }

        private static List<int> Adjust(List<int> givenList, int num)
        {
            var newArray = new List<int>();
            foreach (var number in givenList)
            {
                if (number % num != 0)
                {
                    newArray.Add(number);
                }
            }
            return newArray;
        }
    }
}
