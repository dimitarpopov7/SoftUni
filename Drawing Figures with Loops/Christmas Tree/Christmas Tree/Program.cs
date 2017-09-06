using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 0;
            int spaces = n;
            int middle = 1;
            for (int rows = 0; rows < n + 1; rows++)
            {
                for (int space = 0; space < spaces; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < stars; star++)
                {
                    Console.Write("*");
                }
                for (int midd = 0; midd < middle; midd++)
                {
                    Console.Write(" ");
                }

                for (int midd = 0; midd < middle; midd++)
                {
                    Console.Write("|");
                }
                for (int midd = 0; midd < middle; midd++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < stars; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                spaces--;
                stars++;
            }
        }
    }
}
