using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                int[] condensed = new int[nums.Length - 1];
                for (int i = condensed.Length; i >= 1; i--)
                {
                    for (int k = 0; k < condensed.Length; k++)
                    {
                        condensed[k] = nums[k] + nums[k + 1];
                        nums[k] = condensed[k];
                    }
                }
                Console.WriteLine(condensed[0]);
            }
        }
    }
}
