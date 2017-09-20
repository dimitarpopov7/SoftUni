using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        
            public static void Main()
            {
                string[] firstValues = Console.ReadLine().Split(' ').ToArray();
                string[] secondValues = Console.ReadLine().Split(' ').ToArray();

                int[] firstNums = new int[firstValues.Length];
                int[] secondNums = new int[secondValues.Length];

                int Length = Math.Max(firstNums.Length, secondNums.Length);
                for (int i = 0; i < firstNums.Length; i++)
                {
                    firstNums[i] = int.Parse(firstValues[i]);

                }
                for (int i = 0; i < secondNums.Length; i++)
                {
                    secondNums[i] = int.Parse(secondValues[i]);
                }
                for (int i = 0; i < Length; i++)
                {
                    Console.Write($"{firstNums[i % firstNums.Length] + secondNums[i % secondNums.Length]} ");
                }
                Console.WriteLine();
            }
        }
    }

