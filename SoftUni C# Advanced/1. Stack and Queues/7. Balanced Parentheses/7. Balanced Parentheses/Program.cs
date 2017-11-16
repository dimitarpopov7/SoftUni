namespace _7.Balanced_Parentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().ToCharArray();
            if (entry.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            var stack = new Stack<char>();            
            var queue = new Queue<char>();
            
            foreach (var item in entry)
            {
                queue.Enqueue(item);
            }

            entry.Reverse();

            foreach (var item in entry)
            {
                stack.Push(item);
            }
            while (queue.Count!=0)
            {
                var currentSymbolQ = queue.Dequeue();
                var currentSymbolS = stack.Pop();
                if (currentSymbolQ == '('&&currentSymbolS==')')
                {
                    continue;
                }
                else if (currentSymbolQ == '{' && currentSymbolS == '}')
                {
                    continue;
                }
                else if (currentSymbolQ == '[' && currentSymbolS == ']')
                {
                    continue;
                }
                else if (currentSymbolQ == ')' && currentSymbolS == '(')
                {
                    continue;
                }
                else if (currentSymbolQ == '}' && currentSymbolS == '{')
                {
                    continue;
                }
                else if (currentSymbolQ == ']' && currentSymbolS == '[')
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
