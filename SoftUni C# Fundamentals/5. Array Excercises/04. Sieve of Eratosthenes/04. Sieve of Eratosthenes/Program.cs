using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;
            for (int i = 2; i <= n; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write($"{i} ");

                    for (int k = 0; k <= n; k++)
                    {
                        if (k * i <= n)
                        {
                            primes[k * i] = false;
                        }
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
