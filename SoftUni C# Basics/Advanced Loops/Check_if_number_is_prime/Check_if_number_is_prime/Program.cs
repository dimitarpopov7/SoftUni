﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_number_is_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool prime = (n > 1);
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");
        }
    }
}
