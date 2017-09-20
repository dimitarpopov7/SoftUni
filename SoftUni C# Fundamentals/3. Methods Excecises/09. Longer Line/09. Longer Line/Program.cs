using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            //test two lines
            double lineOne = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) + Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            double lineTwo = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2)) + Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

            if (lineOne > lineTwo)
            {
                longestTwoLines(x1, y1, x2, y2);
            }
            else
            {
                longestTwoLines(x3, y3, x4, y4);
            }

        }
        static double longestTwoLines(double x1, double y1, double x2, double y2)
        {
            double lineOne = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double lineTwo = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (lineOne <= lineTwo)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            return 1;
        }
    }
}
