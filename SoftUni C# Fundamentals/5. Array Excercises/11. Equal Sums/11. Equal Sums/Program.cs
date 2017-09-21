using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            if (numbers.Length == 1)
            {
                Console.WriteLine(0);                
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int left = 0; left < i; left++)
                    {
                        leftSum += numbers[left];
                    }
                    for (int right = numbers.Length - 1; right > i; right--)
                    {
                        rightSum += numbers[right];
                    }
                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                    leftSum = 0;
                    rightSum = 0;
                }
                Console.WriteLine("no");
            }            
        }
    }
}
