using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Factorial(n);

        }
        static BigInteger Factorial(BigInteger n)
        {
            BigInteger sum = 0;
            BigInteger factorial = 1;
            int zeroCount = 0;

            for (BigInteger num = n; num >= 1; num--)
            {
                sum = factorial * num;
                factorial = sum;
            }
            while (sum > 0)
            {
                if (sum % 10 == 0)
                {
                    zeroCount++;
                }
                else if (sum % 10 != 0)
                {
                    break;
                }
                sum = sum / 10;
            }
            Console.WriteLine(zeroCount);
            return sum;
        }
    }
}
