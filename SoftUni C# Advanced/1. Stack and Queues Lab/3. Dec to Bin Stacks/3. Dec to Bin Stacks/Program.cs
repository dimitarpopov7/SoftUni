namespace _3.Dec_to_Bin_Stacks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split().Select(int.Parse).ToList();
            var stack = new Stack<string>();
            foreach (var num in entry)
            {
                stack.Push(Convert.ToString(num, 2));
            }
            Console.Write(string.Join("",stack));
        }
    }
}
