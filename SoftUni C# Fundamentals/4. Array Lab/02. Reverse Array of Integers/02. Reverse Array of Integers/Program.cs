using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n - 1; i >= 0; i--)
            {
                int reversed = nums[i];

                Console.WriteLine(reversed);
            }
        }
    }
}
