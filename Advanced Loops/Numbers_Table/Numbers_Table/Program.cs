using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int rows = 0; rows < n; rows++)
            {
                for (int col = 0; col < n; col++)
                {
                    num = rows + col + 1; //Need to include if before cw, otherwise it would not include the changes in -num+2*n
                    if (num > n)
                    {
                        num = 2 * n - num;

                    }
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}
