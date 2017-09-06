using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b - a < 3)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = i + 1; j <= b; j++)
                    {
                        for (int k = j + 1; k <= b; k++)
                        {
                            for (int z = k + 1; z <= b; z++)
                            {
                                Console.WriteLine($"{i} {j} {k} {z}");
                            }
                        }
                    }
                }
            }
        }
    }
}
