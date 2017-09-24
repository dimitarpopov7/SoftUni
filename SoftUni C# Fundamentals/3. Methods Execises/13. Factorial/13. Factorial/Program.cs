using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
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

            for (BigInteger num = n; num >= 1; num--)
            {


                sum = factorial * num;
                factorial = sum;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
