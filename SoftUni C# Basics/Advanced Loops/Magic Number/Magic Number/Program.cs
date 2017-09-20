using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int first = 0; first < 9; first++)
                for (int second = 0; second < 9; second++)
                    for (int third = 0; third < 9; third++)
                        for (int fourth = 0; fourth < 9; fourth++)
                            for (int fifth = 0; fifth < 9; fifth++)
                                for (int sixth = 0; sixth < 9; sixth++)
                                {
                                    if (first * second * third * fourth * fifth * sixth == n)
                                    {
                                        Console.Write($"{first}{second}{third}{fourth}{fifth}{sixth} ");
                                    }
                                }
            Console.WriteLine();
        }
    }
}
