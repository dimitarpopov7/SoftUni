using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Prices
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesNum = int.Parse(Console.ReadLine());
            string typePics = Console.ReadLine();
            string orderType = Console.ReadLine();
            double price9X13 = picturesNum * 0.16;
            double price9X13over50 = picturesNum * 0.16 * .95;
            double price10X15 = picturesNum * 0.16;
            double price10X15over80 = picturesNum * 0.16 * .97;
            double price13X18 = picturesNum * 0.38;
            double price13X18over50 = picturesNum * 0.38 * .97;
            double price13X18over100 = picturesNum * 0.38 * .95;
            double price20X30 = picturesNum * 2.90;
            double price20X30over10 = picturesNum * 2.90 * .93;
            double price20X30over50 = picturesNum * 2.90 * .91;
            if (orderType == "online")
            {
                price9X13 = price9X13 * .98;
                price9X13over50 = price9X13over50 * .98;
                price10X15 = price10X15 * .98;
                price10X15over80 = price10X15over80 * .98;
                price13X18over50 = price13X18over50 * .98;
                price13X18 = price13X18 * .98;
                price13X18over100 = price13X18over100 * .98;
                price20X30 = price20X30 * .98;
                price20X30over10 = price20X30over10 * .98;
                price20X30over50 = price20X30over50 * .98;
                if (typePics == "9X13" && picturesNum < 50)
                {
                    Console.WriteLine("{0:f2}BGN", price9X13);
                }
                else if (typePics == "9X13" && picturesNum >= 50)
                {
                    Console.WriteLine("{0:f2}BGN", price9X13over50);
                }
                else if (typePics == "10X15" && picturesNum < 50)
                {
                    Console.WriteLine("{0:f2}BGN", price10X15);
                }
                else if (typePics == "10X15" && picturesNum >= 80)
                {
                    Console.WriteLine("{0:f2}BGN", price10X15over80);
                }
                else if (typePics == "13X18" && picturesNum < 50)
                {
                    Console.WriteLine("{0:f2}BGN", price13X18);
                }
                else if (typePics == "13X18" && picturesNum >= 50 && picturesNum <= 100)
                {
                    Console.WriteLine("{0:f2}BGN", price13X18over50);
                }
                else if (typePics == "13X18" && picturesNum > 100)
                {
                    Console.WriteLine("{0:f2}BGN", price13X18over100);
                }

                else if (typePics == "20X30" && picturesNum < 10)
                {
                    Console.WriteLine("{0:f2}BGN", price20X30);
                }
                else if (typePics == "20X30" && picturesNum >= 10 && picturesNum <= 50)
                {
                    Console.WriteLine("{0:f2}BGN", price20X30over10);
                }
                else if (typePics == "20X30" && picturesNum > 50)
                {
                    Console.WriteLine("{0:f2}BGN", price20X30over50);
                }
            }
            else if (orderType == "office")
            {
                if (typePics == "9X13" && picturesNum < 50)
                {
                    Console.WriteLine("{0:f2}BGN", price9X13);
                }
                else if (typePics == "9X13" && picturesNum >= 50)
                {
                    Console.WriteLine("{0:f2}BGN", price9X13over50);
                }
                else if (typePics == "10X15" && picturesNum < 50)
                {
                    Console.WriteLine("{0:f2}BGN", price10X15);
                }
                else if (typePics == "10X15" && picturesNum >= 80)
                {
                    Console.WriteLine("{0:f2}BGN", price10X15over80);
                }
                else if (typePics == "13X18" && picturesNum < 50)
                {
                    Console.WriteLine("{0:f2}BGN", price13X18);
                }
                else if (typePics == "13X18" && picturesNum >= 50 && picturesNum <= 100)
                {
                    Console.WriteLine("{0:f2}BGN", price13X18over50);
                }
                else if (typePics == "13X18" && picturesNum > 100)
                {
                    Console.WriteLine("{0:f2}BGN", price13X18over100);
                }

                else if (typePics == "20X30" && picturesNum < 10)
                {
                    Console.WriteLine("{0:f2}BGN", price20X30);
                }
                else if (typePics == "20X30" && picturesNum >= 10 && picturesNum <= 50)
                {
                    Console.WriteLine("{0:f2}BGN", price20X30over10);
                }
                else if (typePics == "20X30" && picturesNum > 50)
                {
                    Console.WriteLine("{0:f2}BGN", price20X30over50);
                }
            }
        }
    }
}
