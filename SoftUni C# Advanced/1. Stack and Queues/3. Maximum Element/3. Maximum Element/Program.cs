namespace _3.Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            int maxNum = 0;
            int currentNum = 0;
            var stackMaxElement = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToList();                
                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                    currentNum = command[1];
                    if (maxNum < currentNum)
                    {
                        maxNum = currentNum;
                        stackMaxElement.Push(maxNum);
                    }
                }
                else if (command[0] == 2)
                {
                    if (stack.Peek() == maxNum)
                    {
                        stackMaxElement.Pop();
                        if (stackMaxElement.Count > 0)
                        {
                            maxNum = stackMaxElement.Peek();
                        }
                        else
                        {
                            maxNum = 0;
                        }
                    }
                    stack.Pop();                    
                }
                else if (command[0] == 3)
                {
                    Console.WriteLine(stackMaxElement.Max());
                }            
            }
        }
    }
}
