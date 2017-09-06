using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstFibNumber = 1;
            int secondFibNumber = 1;
            int sum = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                sum = firstFibNumber + secondFibNumber;
                firstFibNumber = secondFibNumber;
                secondFibNumber = sum;
            }
            Console.WriteLine(firstFibNumber);
        }
    }
}
