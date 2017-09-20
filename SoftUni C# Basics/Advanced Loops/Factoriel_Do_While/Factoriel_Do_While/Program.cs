using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int result = 1;
            do
            {
                result = result * a;
                a--;
            }
            while (a > 1);
            Console.WriteLine(result);
        }
    }
}
