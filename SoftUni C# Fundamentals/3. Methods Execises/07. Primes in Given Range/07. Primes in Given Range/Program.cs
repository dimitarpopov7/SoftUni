using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            var primesInRange = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", primesInRange));
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();
            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
        }
        static bool IsPrime(long n)
        {
            int sqrtN = (int)Math.Sqrt(n);
            if (n <= 1)
            {
                return false;
            }
            else if (n > 2)
            {
                for (int cnt = 2; cnt <= sqrtN; cnt++)
                {
                    if (n % cnt == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
