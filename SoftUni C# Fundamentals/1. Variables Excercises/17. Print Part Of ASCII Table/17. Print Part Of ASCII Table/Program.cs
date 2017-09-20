using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char one = (char)num1;
            char two = (char)num2;
            for (char i = one; i <= two; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    }

