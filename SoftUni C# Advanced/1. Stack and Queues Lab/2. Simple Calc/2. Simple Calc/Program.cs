namespace _2.Simple_Calc
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] {" " },StringSplitOptions.RemoveEmptyEntries).ToList();
            var stackNum = new Stack<int>();
            var signs = new Stack<string>();
            foreach (var item in numbers)
            {
                if (item == "+" || item == "-")
                {
                    signs.Push(item);
                }
                else
                {
                    stackNum.Push(int.Parse(item));
                }
            }
            var result = 0;
            var sign = string.Empty;
            while (stackNum.Count != 0)
            {
                if (signs.Count == 0)
                {
                    result += stackNum.Pop();
                    break;
                }
                sign = signs.Pop();
                if (sign == "+")
                {
                    result += stackNum.Pop();
                }
                else
                {
                    result -= stackNum.Pop();
                }
            }
            Console.WriteLine(result);
        }
    }
}
