using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        public static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            num = Math.Abs(num);
            long lastDigit = GetLastDigit(num);
            string lastDigitAsWord = GetLastDigitAsWord(lastDigit);

        }

        public static string GetLastDigitAsWord(long lastDigit)
        {
            string lastDigitAsWord = string.Empty;
            if (lastDigit == 1)
            {
                Console.WriteLine("one");
            }
            else if (lastDigit == 2)
            {
                Console.WriteLine("two");
            }
            else if (lastDigit == 3)
            {
                Console.WriteLine("three");
            }
            else if (lastDigit == 4)
            {
                Console.WriteLine("four");
            }
            else if (lastDigit == 5)
            {
                Console.WriteLine("five");
            }
            else if (lastDigit == 6)
            {
                Console.WriteLine("six");
            }
            else if (lastDigit == 7)
            {
                Console.WriteLine("seven");
            }
            else if (lastDigit == 8)
            {
                Console.WriteLine("eight");
            }
            else if (lastDigit == 9)
            {
                Console.WriteLine("nine");
            }
            else if (lastDigit == 0)
            {
                Console.WriteLine("zero");
            }
            return lastDigitAsWord;
        }

        public static int GetLastDigit(long num)
        {
            long lastDigit = num % 10;
            return (int)lastDigit;
        }
    }
}
