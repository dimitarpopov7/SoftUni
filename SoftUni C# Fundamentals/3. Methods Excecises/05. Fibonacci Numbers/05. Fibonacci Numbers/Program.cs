using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Fibonacci(n);
            }
        }
        public static int Fibonacci(int n)
        {
            int firstFib = 1;
            int secondFib = 1;
            int nextFib = 0;
            for (int i = 2; i <= n; i++)
            {
                nextFib = firstFib + secondFib;
                firstFib = secondFib;
                secondFib = nextFib;
            }
            Console.WriteLine(nextFib);
            return nextFib;
        }
    }
}
