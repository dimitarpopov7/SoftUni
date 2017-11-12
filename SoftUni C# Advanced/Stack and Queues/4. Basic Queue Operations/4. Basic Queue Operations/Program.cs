namespace _4.Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var commands = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            var queueCount = commands[0] - commands[1];
            if (queueCount == 0)
            {
                Console.WriteLine(0);
                return;
            }
            var numberToFind = commands[2];

            var entry = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            var queue = new Queue<int>();
            entry.ForEach(x => queue.Enqueue(x));

            for (int i = 0; i < commands[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == queueCount && queue.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                var hashset = new SortedSet<int>(queue);
                foreach (var item in hashset.Take(1))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
