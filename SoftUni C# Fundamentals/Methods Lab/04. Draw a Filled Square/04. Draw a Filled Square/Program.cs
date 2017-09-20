using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddle(n);
            }
            PrintHeader(n);

        }
        public static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        public static void PrintMiddle(int n)
        {
            Console.Write("-");
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
