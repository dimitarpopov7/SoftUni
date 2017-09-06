using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letterWithout = char.Parse(Console.ReadLine());
            int count = 0;
            for (char one = letter1; one <= letter2; one++)
            {
                for (char two = letter1; two <= letter2; two++)
                {
                    for (char tree = letter1; tree <= letter2; tree++)
                    {
                        if (one != letterWithout && two != letterWithout && tree != letterWithout)
                        {
                            count++;
                            Console.Write($"{one}{two}{tree} ");

                        }
                    }

                }
            }
            Console.Write(count);
            Console.WriteLine();
        }
    }
}
