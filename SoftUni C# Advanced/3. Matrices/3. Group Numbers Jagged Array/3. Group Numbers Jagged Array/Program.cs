namespace _3.Group_Numbers_Jagged_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();
            var list1 = new List<int>();
            var list2 = new List<int>();
            var list3 = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Abs(numbers[i]) % 3 == 0)
                {
                    list1.Add(numbers[i]);
                }
                else if (Math.Abs(numbers[i]) % 3 == 1)
                {
                    list2.Add(numbers[i]);
                }
                else if (Math.Abs(numbers[i]) % 3 == 2)
                {
                    list3.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", list1));
            Console.WriteLine(string.Join(" ", list2));
            Console.WriteLine(string.Join(" ", list3));

            //var reminderZero = numbers.Where(x => Math.Abs(x) % 3 == 0).ToArray();
            //var reminderOne = numbers.Where(x => Math.Abs(x) % 3 == 1).ToArray();
            //var reminderTwo = numbers.Where(x => Math.Abs(x) % 3 == 2).ToArray();            
            //Console.WriteLine(stopwatch.ElapsedTicks);
            //Console.WriteLine(string.Join(" ", reminderZero));
            //Console.WriteLine(string.Join(" ", reminderOne));
            //Console.WriteLine(string.Join(" ", reminderTwo));
       }
    }
}
