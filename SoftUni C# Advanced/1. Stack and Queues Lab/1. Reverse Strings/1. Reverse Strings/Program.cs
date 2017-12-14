namespace _1.Reverse_Strings
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().ToCharArray();
            var stack = new Stack<char>();
            foreach (var letter in entry)
            {
                stack.Push(letter);
            }
            Console.Write(string.Join("",stack));
        }
    }
}
