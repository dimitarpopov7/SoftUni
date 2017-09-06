using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstDot = 0;
            int secondDot = n;
            int firsDot2 = n - 2;
            int secondDot2 = 2;
            //Upperbody
            for (int row = 1; row <= n + 1; row++)
            {
                if (row != n && row != n + 1)
                {
                    for (int first = 1; first <= firstDot; first++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int i = 1; i <= secondDot; i++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int i = 1; i <= secondDot; i++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int first = 1; first <= firstDot; first++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                    firstDot++;
                    secondDot--;
                }
                else if (row == n)
                {
                    for (int beforeMidd = 1; beforeMidd <= n - 1; beforeMidd++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*****");
                    for (int beforeMidd2 = 1; beforeMidd2 <= n - 1; beforeMidd2++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
                else if (row == n + 1)
                {
                    for (int midStar = 1; midStar <= 2 * n + 3; midStar++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            //Lower Body
            for (int lowerB = 1; lowerB <= n; lowerB++)
            {
                if (lowerB == 1)
                {
                    for (int beforeMidd = 1; beforeMidd <= n - 1; beforeMidd++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*****");
                    for (int beforeMidd2 = 1; beforeMidd2 <= n - 1; beforeMidd2++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
                else if (lowerB != 1)
                {
                    for (int firsTDot2L = 1; firsTDot2L <= firsDot2; firsTDot2L++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int secondDot2L = 1; secondDot2L <= secondDot2; secondDot2L++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int secondDot2L = 1; secondDot2L <= secondDot2; secondDot2L++)
                    {
                        Console.Write(".");
                    }
                    Console.Write("*");
                    for (int firsTDot2L = 1; firsTDot2L <= firsDot2; firsTDot2L++)
                    {
                        Console.Write(".");
                    }

                    firsDot2--;
                    secondDot2++;
                    Console.WriteLine();
                }
            }
        }
    }
}
