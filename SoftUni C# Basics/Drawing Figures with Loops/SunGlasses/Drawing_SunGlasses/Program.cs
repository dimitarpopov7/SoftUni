using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 3 || n > 100)
            {
                return;
            }
            else if (n % 2 == 0)
            {
                for (int Rows = 0; Rows < n; Rows++)
                {
                    if (Rows == 0 || Rows == n - 1)
                    {
                        for (int top = 0; top < n * 2; top++)
                        {
                            Console.Write("*");
                        }
                        for (int topMidd = 0; topMidd < n; topMidd++)
                        {
                            Console.Write(" ");
                        }
                        for (int top = 0; top < n * 2; top++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    else if (Rows != 0 && Rows != n - 1 && Rows != n / 2 - 1)
                    {
                        for (int middleFirstStar = 0; middleFirstStar < 1; middleFirstStar++)
                        {
                            Console.Write("*");
                        }
                        for (int italicDash = 0; italicDash < n * 2 - 2; italicDash++)
                        {
                            Console.Write("/");
                        }
                        for (int middleEndStar = 0; middleEndStar < 1; middleEndStar++)
                        {
                            Console.Write("*");
                        }
                        for (int middEmpty = 0; middEmpty < n; middEmpty++)
                        {
                            Console.Write(" ");
                        }
                        for (int middleFirstStar = 0; middleFirstStar < 1; middleFirstStar++)
                        {
                            Console.Write("*");
                        }
                        for (int italicDash = 0; italicDash < n * 2 - 2; italicDash++)
                        {
                            Console.Write("/");
                        }
                        for (int middleEndStar = 0; middleEndStar < 1; middleEndStar++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    else if (Rows == n / 2 - 1)
                    {
                        for (int midd = 0; midd < 1; midd++)
                        {
                            Console.Write("*");
                        }
                        for (int midd2 = 0; midd2 < n * 2 - 2; midd2++)
                        {
                            Console.Write("/");
                        }
                        for (int midd = 0; midd < 1; midd++)
                        {
                            Console.Write("*");
                        }
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("|");
                        }
                        for (int midd = 0; midd < 1; midd++)
                        {
                            Console.Write("*");
                        }
                        for (int midd2 = 0; midd2 < n * 2 - 2; midd2++)
                        {
                            Console.Write("/");
                        }
                        for (int midd = 0; midd < 1; midd++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }

            else if (n % 2 == 1)
            {
                for (int RowsOdd = 0; RowsOdd < n; RowsOdd++)
                {
                    if (RowsOdd == 0 || RowsOdd == n - 1)
                    {
                        for (int top = 0; top < n * 2; top++)
                        {
                            Console.Write("*");
                        }
                        for (int topMidd = 0; topMidd < n; topMidd++)
                        {
                            Console.Write(" ");
                        }
                        for (int top = 0; top < n * 2; top++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    else if (RowsOdd == n / 2)
                    {
                        for (int midd = 0; midd < 1; midd++)
                        {
                            Console.Write("*");
                        }
                        for (int midd2 = 0; midd2 < n * 2 - 2; midd2++)
                        {
                            Console.Write("/");
                        }
                        for (int midd = 0; midd < 1; midd++)
                        {
                            Console.Write("*");
                        }
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("|");
                        }
                        for (int midd = 0; midd < 1; midd++)
                        {
                            Console.Write("*");
                        }
                        for (int midd2 = 0; midd2 < n * 2 - 2; midd2++)
                        {
                            Console.Write("/");
                        }
                        for (int midd = 0; midd < 1; midd++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    else if (RowsOdd != 0 && RowsOdd != n - 1 && RowsOdd != n / 2)
                    {
                        for (int middleFirstStar = 0; middleFirstStar < 1; middleFirstStar++)
                        {
                            Console.Write("*");
                        }
                        for (int italicDash = 0; italicDash < n * 2 - 2; italicDash++)
                        {
                            Console.Write("/");
                        }
                        for (int middleEndStar = 0; middleEndStar < 1; middleEndStar++)
                        {
                            Console.Write("*");
                        }
                        for (int middEmpty = 0; middEmpty < n; middEmpty++)
                        {
                            Console.Write(" ");
                        }
                        for (int middleFirstStar = 0; middleFirstStar < 1; middleFirstStar++)
                        {
                            Console.Write("*");
                        }
                        for (int italicDash = 0; italicDash < n * 2 - 2; italicDash++)
                        {
                            Console.Write("/");
                        }
                        for (int middleEndStar = 0; middleEndStar < 1; middleEndStar++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }

                }

            }
        }
    }
}
