using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            Body();
            Footer();

        }
        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

    }
}
