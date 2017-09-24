using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int startIndex = 0;
            int count = 0;
            int maxRepeats = 0;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                if (array1[i] == array1[i + 1])
                {
                    count++;
                    if (count > maxRepeats)
                    {
                        startIndex = i - count;
                        maxRepeats = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = startIndex + 1; i <= startIndex + maxRepeats + 1; i++)
            {
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();
        }
    }
}
