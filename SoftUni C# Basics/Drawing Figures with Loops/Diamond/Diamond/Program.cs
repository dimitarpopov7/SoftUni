using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sideDash = (n - 1) / 2;
            int sidedashBot = (n - 1) / 2;
            int star = 1;
            int middDash = 0;
            int middDash2 = -1;
            if (n % 2 == 0)
            {
                for (int row = 0; row < n / 2; row++)
                {

                    for (int sideDashes = 0; sideDashes < sideDash; sideDashes++)
                    {
                        Console.Write("-");
                    }
                    for (int starS = 0; starS < star; starS++)
                    {
                        Console.Write("*");
                    }
                    for (int middleDash = 0; middleDash < middDash; middleDash++)
                    {
                        Console.Write("-");
                    }
                    for (int starS = 0; starS < star; starS++)
                    {
                        Console.Write("*");
                    }
                    for (int sideDashes = 0; sideDashes < sideDash; sideDashes++)
                    {
                        Console.Write("-");
                    }
                    sideDash--;
                    middDash = middDash + 2;
                    Console.WriteLine();
                }
                //Console.WriteLine("ashdkjshgfhkdsgfhsdfs");
                for (int row = 0; row < n / 2 - 1; row++)
                {
                    for (int sideDashes = 0; sideDashes < sideDash + 2; sideDashes++)
                    {
                        Console.Write("-");
                    }
                    for (int starS = 0; starS < star; starS++)
                    {
                        Console.Write("*");
                    }
                    for (int middleDash = 0; middleDash < middDash - 4; middleDash++)
                    {
                        Console.Write("-");
                    }
                    for (int starS = 0; starS < star; starS++)
                    {
                        Console.Write("*");
                    }
                    for (int sideDashes = 0; sideDashes < sideDash + 2; sideDashes++)
                    {
                        Console.Write("-");
                    }
                    sideDash++;
                    middDash = middDash - 2;
                    Console.WriteLine();
                }
            }
            //ODD PART
            else if (n % 2 == 1)
            {
                for (int row = 0; row < n / 2 + 1; row++)
                {
                    if (row == 0)
                    {
                        for (int sideDashes = 0; sideDashes < sideDash; sideDashes++)
                        {
                            Console.Write("-");
                        }
                        for (int starS = 0; starS < star; starS++)
                        {
                            Console.Write("*");
                        }
                        for (int middleDash = 0; middleDash < middDash2; middleDash++)
                        {
                            Console.Write("-");
                        }
                        for (int sideDashes = 0; sideDashes < sideDash; sideDashes++)
                        {
                            Console.Write("-");
                        }

                    }
                    else if (row != 0)
                    {
                        for (int sideDashes = 0; sideDashes < sideDash; sideDashes++)
                        {
                            Console.Write("-");
                        }
                        for (int starS = 0; starS < star; starS++)
                        {
                            Console.Write("*");
                        }
                        for (int middleDash = 0; middleDash < middDash2; middleDash++)
                        {
                            Console.Write("-");
                        }
                        for (int starS = 0; starS < star; starS++)
                        {
                            Console.Write("*");
                        }
                        for (int sideDashes = 0; sideDashes < sideDash; sideDashes++)
                        {
                            Console.Write("-");
                        }
                    }

                    sideDash--;
                    middDash2 = middDash2 + 2;
                    Console.WriteLine();

                }
                for (int row = 0; row < n / 2; row++)
                {
                    if (row != n / 2 && row != (n / 2) - 1)
                    {
                        for (int sideDashes = 0; sideDashes < sideDash + 2; sideDashes++)
                        {
                            Console.Write("-");
                        }
                        for (int starS = 0; starS < star; starS++)
                        {
                            Console.Write("*");
                        }
                        for (int middleDash = 0; middleDash < middDash2 - 4; middleDash++)
                        {
                            Console.Write("-");
                        }
                        for (int starS = 0; starS < star; starS++)
                        {
                            Console.Write("*");
                        }
                        for (int sideDashes = 0; sideDashes < sideDash + 2; sideDashes++)
                        {
                            Console.Write("-");
                        }
                    }
                    else if (row == (n / 2) - 1)
                    {
                        for (int botomSide = 0; botomSide < sidedashBot; botomSide++)
                        {
                            Console.Write("-");
                        }
                        for (int stars = 0; stars < star; stars++)
                        {
                            Console.Write("*");
                        }
                        for (int botomSide = 0; botomSide < sidedashBot; botomSide++)
                        {
                            Console.Write("-");
                        }
                    }
                    sideDash++;
                    sidedashBot = sidedashBot;
                    middDash2 = middDash2 - 2;
                    Console.WriteLine();
                }
            }
        }
    }
}
