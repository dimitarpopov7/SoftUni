namespace _2.Basic_Stack_Operations
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

            var stackCount = commands[0] - commands[1];
            var numberToFind = commands[2];

            var entry=Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            var stack = new Stack<int>();
            entry.ForEach(x => stack.Push(x));

            for (int i = 0; i < commands[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Count == stackCount && stack.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                var listOfNums = new List<int>(stack);
                listOfNums.Sort();
                if (listOfNums.Count == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
                Console.WriteLine(listOfNums[0]);
            }
        }
    }
}
