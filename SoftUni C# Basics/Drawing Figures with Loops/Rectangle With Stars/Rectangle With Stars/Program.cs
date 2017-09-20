using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_With_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                for (int i = 0; i < n + 1; i++)
                {
                    if (i == 0 || i == (n))
                    {
                        Console.Write(new string('%', n * 2));
                    }
                    else if (i != 0 && i != (n * 2 - 2) && i != (n + 1) / 2)
                    {
                        Console.Write(new string('%', 1));
                        for (int column = 0; column < n * 2 - 2; column++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(new string('%', 1));
                    }
                    if (i == (n + 1) / 2)
                    {
                        Console.Write(new string('%', 1));
                        for (int column = 0; column < n - 2; column++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(new string('*', 2));
                        for (int column = 0; column < n - 2; column++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(new string('%', 1));
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n + 2; i++)
                {
                    if (i == 0 || i == (n + 1))
                    {
                        Console.Write(new string('%', n * 2));
                    }
                    else if (i != 0 && i != (n * 2 - 2) && i != (n + 1) / 2)
                    {
                        Console.Write(new string('%', 1));
                        for (int column = 0; column < n * 2 - 2; column++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(new string('%', 1));
                    }
                    if (i == (n + 1) / 2)
                    {
                        Console.Write(new string('%', 1));
                        for (int column = 0; column < n - 2; column++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(new string('*', 2));
                        for (int column = 0; column < n - 2; column++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(new string('%', 1));
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
