using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = Console.ReadLine();
            if (variable == "int")
            {
                Integer();
            }
            else if (variable == "char")
            {
                Char();
            }
            else if (variable == "string")
            {
                String();
            }
        }
        public static void Integer()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(a, b));
        }
        public static void Char()
        {
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());
            Console.WriteLine((char)Math.Max(letterOne, letterTwo));
        }
        public static void String()
        {
            string wordOne = Console.ReadLine();
            string wordTwo = Console.ReadLine();
            if (wordOne.CompareTo(wordTwo) >= 0)
            {
                Console.WriteLine(wordOne);
            }
            else
            {
                Console.WriteLine(wordTwo);
            }
        }
    }
}
