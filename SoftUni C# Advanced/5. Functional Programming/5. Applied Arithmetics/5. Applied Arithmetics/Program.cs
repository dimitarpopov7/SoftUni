namespace _5.Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var queNums = new Queue<int>(numbers);
            Func<Queue<int>, string, Queue<int>> action;
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", queNums));
                    command = Console.ReadLine();
                    continue;
                }
                queNums = Actions(queNums, command);
                command = Console.ReadLine();
            }
        }
	    public static Queue<int> Actions(Queue<int> numbers,string command)
        {
            var newQueue = new Queue<int>();
            if (command == "add")
            {
                foreach (var num in numbers)
                {
                    newQueue.Enqueue(num + 1);
                }
            }
            else if (command == "subtract")
            {
                foreach (var num in numbers)
                {
                    newQueue.Enqueue(num - 1);
                }
            }
            else if (command == "multiply")
            {
                foreach (var num in numbers)
                {
                    newQueue.Enqueue(num * 2);
                }
            }
            else if (command == "divide")
            {
                foreach (var num in numbers)
                {
                    newQueue.Enqueue(num / 2);
                }
            }            
            return newQueue;
        }
    }
}
