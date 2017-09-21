using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            int maxCount = 0;
            int num = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                for (int k = 0; k < sequence.Length; k++)
                {
                    if (sequence[i] == sequence[k])
                    {
                        count++;                       
                    }                    
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    num = sequence[i];
                    count = 0;
                }
                count = 0;
            }
            Console.WriteLine(num);
        }
    }
}
