using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digit3 = n % 10;
            int digit2 = (n / 10) % 10;
            int digit1 = (n / 100) % 10;

            for (int rows = 1; rows <= (digit1 + digit2); rows++)
            {
                for (int columns = 1; columns <= (digit1 + digit3); columns++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - digit1;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - digit2;
                    }

                    else if (n % 5 != 0 && n % 3 != 0)
                    {
                        n = n + digit3;
                    }//чак тогава пишем какво да се пише!
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
