using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int letters = int.Parse(Console.ReadLine());
            for (int digitOne = 1; digitOne <= digit; digitOne++)
                for (int digitTwo = 1; digitTwo <= digit; digitTwo++)
                    for (char char1 = 'a'; char1 < 'a' + letters; char1++)
                        for (char char2 = 'a'; char2 < 'a' + letters; char2++)
                            for (int lastdigit = Math.Max(digitOne, digitTwo) + 1; lastdigit <= digit; lastdigit++)
                            {
                                Console.Write($"{digitOne}{digitTwo}{char1}{char2}{lastdigit} ");
                            }
            Console.WriteLine();
        }
    }
}
