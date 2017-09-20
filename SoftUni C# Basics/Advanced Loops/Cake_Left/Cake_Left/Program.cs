using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Left
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthOfCake = int.Parse(Console.ReadLine());
            int lengthofCake = int.Parse(Console.ReadLine());
            int numOfCakePeaces = widthOfCake * lengthofCake;
            while (numOfCakePeaces > 0)
            {
                try
                {
                    int pieceTaken = int.Parse(Console.ReadLine());
                    numOfCakePeaces = numOfCakePeaces - pieceTaken;
                    if (numOfCakePeaces < 0)
                    {
                        numOfCakePeaces = Math.Abs(numOfCakePeaces);
                        Console.WriteLine("No more cake left! You need {0} pieces more.", numOfCakePeaces);
                        return;
                    }
                }
                // If we write STOP as a string -> shows how many are left
                catch
                {
                    Console.WriteLine("{0} pieces are left.", numOfCakePeaces);
                    return;
                }

            }
        }
    }
}
