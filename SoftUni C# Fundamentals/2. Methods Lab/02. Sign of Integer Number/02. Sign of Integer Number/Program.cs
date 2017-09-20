using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        static void PrintSign(int a)
        {
            if (a > 0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }
            else if (a < 0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {a} is zero.");
            }
        }
    }
}
