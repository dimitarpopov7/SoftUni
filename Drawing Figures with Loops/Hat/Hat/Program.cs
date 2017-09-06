using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = (n * 2) - 1;
            int middleLeft = 0;
            int middleRight = 0;
            int end = (n * 2) - 1;
            for (int rows = 1; rows <= 2 * n + 5; rows++)
            {
                if (rows == 1)
                {
                    Console.Write(new string('.', n * 2 - 1));
                    Console.Write("/|\\");
                    for (int leftSideBegining = 1; leftSideBegining <= 2 * n - 1; leftSideBegining++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
                else if (rows == 2)
                {
                    Console.Write(new string('.', n * 2 - 1));
                    Console.Write("\\|/");
                    for (int leftSideBegining = 1; leftSideBegining <= 2 * n - 1; leftSideBegining++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }

                else if (rows == 2 * n + 5 - 2)
                {
                    Console.Write(new string('*', 4 * n + 1));
                    Console.WriteLine();
                }
                else if (rows == 2 * n + 5 - 1)
                {

                    for (int lastminus1 = 1; lastminus1 <= n * 2; lastminus1++)
                    {
                        Console.Write("*.");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
                else if (rows == 2 * n + 5)
                {
                    Console.Write(new string('*', 4 * n + 1));
                }
                else if (rows != 2 * n + 5 - 2 || rows != 2 * n + 5 - 1 || rows != 2 * n + 5 || rows != 1 || rows != 2)
                {
                    for (int startPoints = 1; startPoints <= start; startPoints++)
                    {
                        Console.Write(".");

                    }
                    Console.Write("*");
                    for (int firstDash = 1; firstDash <= middleLeft; firstDash++)
                    {
                        Console.Write("-");

                    }
                    Console.Write("*");
                    for (int secondDash = 0; secondDash < middleRight; secondDash++)
                    {
                        Console.Write("-");

                    }
                    Console.Write("*");
                    for (int endPoints = 1; endPoints <= end; endPoints++)
                    {
                        Console.Write(".");

                    }
                    Console.WriteLine();
                    start--;
                    end--;
                    middleLeft = middleLeft + 1;
                    middleRight = middleRight + 1;
                }
            }
            Console.WriteLine();
        }
    }
}
