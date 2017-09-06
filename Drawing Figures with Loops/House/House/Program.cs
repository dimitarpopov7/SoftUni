using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starsOdd = 1;
            int starsOddBott = n - 2;
            int starsEven = 2;
            int starsEvenBott = n - 2;
            int dashL = (n - 1) / 2;
            int dashR = (n - 1) / 2;
            int pipeL = 1;
            int pipeR = 1;
            //ODD
            if (n % 2 == 1 && n >= 2 && n <= 100)
            {
                //top part for odd
                for (int row = 0; row < n / 2 + 1; row++)
                {
                    for (int dashLeft = 0; dashLeft < dashL; dashLeft++)
                    {
                        Console.Write("-");
                    }
                    for (int star = 0; star < starsOdd; star++)
                    {
                        Console.Write("*");
                    }
                    for (int dashRight = 0; dashRight < dashR; dashRight++)
                    {
                        Console.Write("-");
                    }
                    dashL--;
                    dashR--;
                    starsOdd = starsOdd + 2;
                    Console.WriteLine();
                }
                //bottom part for odd
                for (int rowBottom = 0; rowBottom < n / 2; rowBottom++)
                {
                    for (int pipeLeft = 0; pipeLeft < pipeL; pipeLeft++)
                    {
                        Console.Write("|");
                    }
                    for (int starsBottom = 0; starsBottom < starsOddBott; starsBottom++)
                    {
                        Console.Write("*");
                    }
                    for (int pipeRight = 0; pipeRight < pipeR; pipeRight++)
                    {
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
            }

            //EVEN
            else if (n % 2 == 0 && n >= 2 && n <= 100)
            {
                //Top Even
                for (int row = 0; row < n / 2; row++)
                {
                    for (int dashLeft = 0; dashLeft < dashL; dashLeft++)
                    {
                        Console.Write("-");
                    }
                    for (int star = 0; star < starsEven; star++)
                    {
                        Console.Write("*");
                    }
                    for (int dashRight = 0; dashRight < dashR; dashRight++)
                    {
                        Console.Write("-");
                    }
                    dashL--;
                    dashR--;
                    starsEven = starsEven + 2;
                    Console.WriteLine();
                }

                //bottom part for Even
                for (int rowBottom = 0; rowBottom < n / 2; rowBottom++)
                {
                    for (int pipeLeft = 0; pipeLeft < pipeL; pipeLeft++)
                    {
                        Console.Write("|");
                    }
                    for (int starsBottom = 0; starsBottom < starsEvenBott; starsBottom++)
                    {
                        Console.Write("*");
                    }
                    for (int pipeRight = 0; pipeRight < pipeR; pipeRight++)
                    {
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
