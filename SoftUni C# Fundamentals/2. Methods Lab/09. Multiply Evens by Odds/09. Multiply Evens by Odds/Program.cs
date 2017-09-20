using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            foreach (int symbol in number.ToString())
            {
                int digit = symbol - '0';
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else if (digit % 2 == 1)
                {
                    sumOdd += digit;
                }
            }
            int total = sumEven * sumOdd;
            Console.WriteLine(total);
        }
    }
}
