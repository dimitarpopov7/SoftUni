using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Name();
        }
        static void Name()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
