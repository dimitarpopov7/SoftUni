using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char vowel = char.Parse(Console.ReadLine());
            if (vowel == 'a' || vowel == 'e' || vowel == 'o' || vowel == 'u' || vowel == 'y' || vowel == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (vowel == '0' || vowel == '1' || vowel == '2' || vowel == '3' || vowel == '4' || vowel == '5' || vowel == '6' || vowel == '7' || vowel == '8' || vowel == '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
