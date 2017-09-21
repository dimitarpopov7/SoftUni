using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int count = 1;
            while (numbers.Count >= 1)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[0] == numbers[j + 1])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{numbers[0]} -> {count}");
                int num = numbers[0];
                numbers.RemoveAll(x => x == num);
                count = 1;
            }                        
        }
    }
}
