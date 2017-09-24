using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perim = ((width + height) * 2);
            double area = (width * height);
            double diagonal = Math.Sqrt((width * width + height * height));
            Console.WriteLine(perim);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
