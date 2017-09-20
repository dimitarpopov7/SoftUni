using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creates_A_Pyramid_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numbers = 1;
            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(numbers + " ");
                    numbers++;
                    if (numbers == number + 1)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
