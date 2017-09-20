using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Combination_To_Get_Total
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneDollar = int.Parse(Console.ReadLine());
            int twoDollar = int.Parse(Console.ReadLine());
            int fiveDollar = int.Parse(Console.ReadLine());
            int totalDollars = int.Parse(Console.ReadLine());
            for (int a = 0; a <= oneDollar; a++)
            {
                for (int b = 0; b <= twoDollar; b++)
                {
                    for (int c = 0; c <= fiveDollar; c++)
                    {
                        if (a * 1 + b * 2 + c * 5 == totalDollars)
                        {
                            Console.WriteLine("{0} * $ 1 + {1} * $ 2 + {2} * $ 5  = $ {3}", a, b, c, totalDollars);
                        }
                    }
                }
            }
        }
    }
}
