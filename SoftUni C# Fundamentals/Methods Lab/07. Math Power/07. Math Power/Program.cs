using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            Pow(num, pow);

        }
        public static double Pow(double num, double pow)
        {
            double sum = 1;
            for (int i = 1; i <= pow; i++)
            {
                sum *= num;
            }
            Console.WriteLine(sum);
            return 1;
        }
    }
}
