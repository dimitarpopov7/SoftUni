using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            int spaces = n - 1;
            for (int rows = 0; rows < n; rows++)
            {
                for (int space = 0; space < spaces; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < stars; star++)
                {
                    Console.Write("* ");
                }
                for (int space = 0; space < spaces; space++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                stars++;
                spaces--;
            }
            for (int bRows = 0; bRows < n - 1; bRows++)
            {
                for (int bSpaces = 0; bSpaces < spaces + 1; bSpaces++)
                {
                    Console.Write(" ");
                }
                for (int bStar = 0; bStar < stars - 2; bStar++)
                {
                    Console.Write(" *");
                }
                for (int bSpaces = 0; bSpaces < spaces; bSpaces++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                spaces++;
                stars--;
            }
        }
    }
}
