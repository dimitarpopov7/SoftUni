using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Longest_Increasing_Subsequence__LIS_
{
    public class Program
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> sequence = new List<int>();
            sequence.Add(nums[0]);
            List<int> oldSequence = new List<int>();
            oldSequence.Add(nums[0]);

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    sequence.Add(nums[i + 1]);
                }
                else if (nums[i] > nums[i + 1])
                {
                    oldSequence = new List<int>(sequence);
                    sequence.RemoveAll(x => x > nums[i + 1]);
                    sequence.Add(nums[i + 1]);
                }
                sequence = sequence.Distinct().ToList();
            }
            if (oldSequence.Count >= sequence.Count)
            {
                for (int i = 0; i < oldSequence.Count; i++)
                {
                    Console.Write($"{oldSequence[i]} ");
                }
            }
            else
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    Console.Write($"{sequence[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
