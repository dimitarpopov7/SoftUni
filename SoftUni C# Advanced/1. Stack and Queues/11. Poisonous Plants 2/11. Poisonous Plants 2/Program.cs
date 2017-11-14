namespace _11.Poisonous_Plants_2
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
            var indexStack = new Stack<int>();
            int days = 0;
            int plantsCount = plants.Count;
            int newPlantsCount = 0;
            while (plantsCount!=newPlantsCount)
            {
                for (int i = 0; i < plants.Count - 1; i++)
                {
                    int left = plants[i];
                    int right = plants[i+1];
                    if (left < right)
                    {
                        indexStack.Push(i + 1);
                    }
                }
                plantsCount = plants.Count;
                if (indexStack.Count == 0)
                {
                    Console.WriteLine(days);
                    return;
                }
                foreach (var index in indexStack)
                {
                    plants.RemoveAt(index);
                }
                indexStack.Clear();
                days++;
                newPlantsCount = plants.Count;
            }
            Console.WriteLine(days);
        }
    }
}
