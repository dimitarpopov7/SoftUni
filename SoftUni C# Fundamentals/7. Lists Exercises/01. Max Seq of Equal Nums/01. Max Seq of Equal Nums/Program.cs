using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Max_Sequence_of_Equal_Elements
{
    public class Program
    {
        public static void Main()

        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 1;
            int maxCount = 0;
            int startNum = 0;
            int newStartNum = 0;
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                    startNum = nums[i];
                    if (count > maxCount)
                    {
                        newStartNum = startNum;
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                    startNum = 0;
                }
            }
            if (count == 1)
            {
                Console.WriteLine(nums[0]);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write($"{newStartNum} ");
                }
                Console.WriteLine();
            }
        }
    }
}
