namespace _4.Find_Even_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var borders = Console.ReadLine().Split().Select(int.Parse).ToList();
            var type = Console.ReadLine();
            Predicate<int> isEvenOrOdd;
            switch (type)
            {
                case "Even":
                    isEvenOrOdd=x=>x%2==0;
                    break;
                case "Odd":
                    isEvenOrOdd = x => x % 2 != 0;
                    break;
                default:
                    isEvenOrOdd = null;
                    break;
            }
            var result=TakeNums(borders, isEvenOrOdd);
            Console.WriteLine(string.Join(" ",result));
        }
        public static Queue<int> TakeNums(List<int> borders, Predicate<int> EvenOrOdd)
        {
            int startNum = borders[0];
            int endNum = borders[1];
            var numsToPrint = new Queue<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (EvenOrOdd(i))
                {
                    numsToPrint.Enqueue(i);
                }
            }
            return numsToPrint;
        }
    }
}
