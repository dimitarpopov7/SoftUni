﻿using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            bool isSbyte = (-128 <= input) && (input <= 127);
            bool isByte = (0 <= input) && (input <= 255);
            bool isShort = (-32768 <= input) && (input <= 32767);
            bool isUshort = (0 <= input) && (input <= 65535);
            bool isInt = (-2147483648 <= input) && (input <= 2147483647);
            bool isUint = (0 <= input) && (input <= 4294967295);
            bool isLong = (-9223372036854775808 <= input) && (input <= 9223372036854775807);

            if (isSbyte || isByte || isShort || isUshort || isInt || isUint || isLong)
            {
                Console.WriteLine("{0} can fit in:", input);
                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (isByte)
                {
                    Console.WriteLine("* byte");
                }
                if (isShort)
                {
                    Console.WriteLine("* short");
                }
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (isInt)
                {
                    Console.WriteLine("* int");
                }
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }
                if (isLong)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}
