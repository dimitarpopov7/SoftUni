using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                for (int k = 0; k < sequence.Length-1-i; k++)
                {
                    if (Math.Abs(sequence[i]-sequence[k+1+i])==num)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
