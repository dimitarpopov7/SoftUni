using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Reversed_Num
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> reversedNums = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {
                string reverse = new string(numbers[i].ToString().Reverse().ToArray());
                reversedNums.Add(reverse);
            }
            List<int> sumList = new List<int>();
            for (int i = 0; i < reversedNums.Count; i++)
            {
                sumList.Add(Convert.ToInt32(reversedNums[i]));
            }
            Console.WriteLine(sumList.Sum());
        }
    }
}
