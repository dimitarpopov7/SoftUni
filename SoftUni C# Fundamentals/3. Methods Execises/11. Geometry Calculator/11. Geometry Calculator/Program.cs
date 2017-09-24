using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double a;
            double b;
            if (figureType == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                double area = (a * b) / 2;
                Console.WriteLine("{0:f2}", area);
            }
            else if (figureType == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                double area = (a * b);
                Console.WriteLine("{0:f2}", area);
            }
            else if (figureType == "square")
            {
                a = double.Parse(Console.ReadLine());
                double area = Math.Pow(a, 2);
                Console.WriteLine("{0:f2}", area);
            }
            else if (figureType == "circle")
            {
                a = double.Parse(Console.ReadLine());
                double area = Math.Pow(a, 2) * Math.PI;
                Console.WriteLine("{0:f2}", area);
            }
        }
    }
}
