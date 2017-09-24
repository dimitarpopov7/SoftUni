using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int firstComparison = Math.Max(firstNum, secondNum);
            int secondComparison = Math.Max(secondNum, thirdNum);
            int maxNum = Math.Max(firstComparison, secondComparison);
            Console.WriteLine(maxNum);
        }
    }
}
