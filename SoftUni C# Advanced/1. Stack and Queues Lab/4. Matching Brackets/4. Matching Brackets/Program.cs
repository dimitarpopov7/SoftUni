namespace _4.Matching_Brackets
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine();
            var stack = new Stack<int>();
            for (int i = 0; i < entry.Length; i++)
            {
                if (entry[i] == '(')
                {
                    stack.Push(i);
                }
                else if (entry[i] == ')')
                {
                    Console.WriteLine(entry.Substring(stack.Peek(),(i-stack.Pop()+1)));
                }
            }
        }
    }
}
