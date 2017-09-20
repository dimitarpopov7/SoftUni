using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(ReversedNum(num));
        }
        public static double ReversedNum(double num)
        {
            string numString = num.ToString();
            string reversedString = string.Empty;
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                reversedString += numString[i];
            }
            double reversedNum = double.Parse(reversedString);
            return reversedNum;
        }
    }
}
