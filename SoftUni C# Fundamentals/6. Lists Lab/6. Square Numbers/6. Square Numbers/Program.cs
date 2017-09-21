using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_Numbers
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNums = new List<int>();
            numbers.Sort();
            numbers.Reverse();
            foreach (int sqNu in numbers)
            {
                if (sqNu % Math.Sqrt(sqNu) == 0)
                {
                    squareNums.Add(sqNu);
                }
            }
            Console.WriteLine(string.Join(" ",squareNums));
        }
    }
}
