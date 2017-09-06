using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i - 1));
                Console.Write("*");
                for (int row = 0; row < i; row++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            for (int row2 = n - 2; row2 >= 0; row2--)
            {
                Console.Write(new string(' ', n - row2 - 1));
                Console.Write("*");
                for (int row = 0; row < row2; row++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
