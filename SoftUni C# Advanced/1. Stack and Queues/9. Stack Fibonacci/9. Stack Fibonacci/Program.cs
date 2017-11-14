namespace _9.Stack_Fibonacci
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            var fibStack = new Stack<long>();
            fibStack.Push(1);
            fibStack.Push(1);
            long lastNum1 = 0;
            long lastNum2=0;
            long currentFib = 0;
            for (long i = 2; i < n; i++)
            {
                lastNum1= fibStack.Pop();
                lastNum2 = fibStack.Pop();
                currentFib = lastNum1 + lastNum2;
                fibStack.Push(lastNum1);
                fibStack.Push(currentFib);
            }
            Console.WriteLine(fibStack.Pop());
        }
    }
}
