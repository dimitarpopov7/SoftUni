namespace _3.Custom_Min_Function
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Func<List<int>, int> minNum = GetMinNum;
            Console.WriteLine(minNum(numbers));
        }

        private static int GetMinNum(List<int> listOfNums)
        {
            return listOfNums.Min();
        }
    }
}
