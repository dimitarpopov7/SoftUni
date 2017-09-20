using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int prime = 2; prime <= number; prime++)
            {
                bool checker = true;
                for (int primeSqrt = 2; primeSqrt <= Math.Sqrt(prime); primeSqrt++)
                {
                    if (prime % primeSqrt == 0)
                    {
                        checker = false;
                        break;
                    }
                }
                Console.WriteLine($"{prime} -> {checker}");
            }
        }
    }
}
