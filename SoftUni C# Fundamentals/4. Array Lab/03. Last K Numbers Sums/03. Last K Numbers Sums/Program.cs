using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastX = int.Parse(Console.ReadLine());
            long[] array = new long[n];
            array[0] = 1;
            for (int i = 1; i <= n - 1; i++)
            {
                int innerLoopStart = Math.Max(0, i - lastX);
                int innerLoopEnd = i - 1;
                long sum = 0;
                for (int nextNum = innerLoopStart; nextNum <= innerLoopEnd; nextNum++)
                {
                    sum += array[nextNum];
                }
                array[i] = sum;
            }
            Console.WriteLine(string.Join(" ", array));

        }
    }
}
