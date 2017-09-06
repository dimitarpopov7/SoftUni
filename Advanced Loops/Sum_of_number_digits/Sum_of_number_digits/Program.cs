using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_number_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                sumOfDigits = sumOfDigits + lastDigit; //sum of digits is 0 by default
                number = number / 10; //thus we take out the last digit of the number in each loop
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}
