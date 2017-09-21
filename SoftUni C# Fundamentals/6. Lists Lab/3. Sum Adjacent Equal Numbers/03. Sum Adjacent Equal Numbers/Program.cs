using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    public class Program
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] == numbers[j + 1])
                    {
                        numbers[j + 1] += numbers[j];
                        numbers.Remove(numbers[j]);
                    }
                }
            }            
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
