namespace Poisonous_Plants_StockSpanProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x => int.Parse(x))
                                    .ToList();
            var days = new int[n];//saves on which day the plant will die
            var indexStack = new Stack<int>();//keeps the index of the plant that we are looking into
            indexStack.Push(0);
            for (int i = 1; i < plants.Count; i++)
            {
                int maxDays = 0;
                while (indexStack.Count > 0 && plants[indexStack.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[indexStack.Pop()]);//compare it then move left to compare it again until the left plant is smaller than the right plant, then we move to the IF to record the day the right plant will die.
                }
                if (indexStack.Count > 0)
                {
                    days[i] = maxDays + 1;
                }
                indexStack.Push(i);//keeps the last plant that we have observed
            }
            Console.WriteLine(days.Max());
        }
    }
}