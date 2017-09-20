using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterOne = char.Parse(Console.ReadLine());
            char letterTwo = char.Parse(Console.ReadLine());
            char letterThree = char.Parse(Console.ReadLine());
            string one = Convert.ToString(letterOne);
            string two = Convert.ToString(letterTwo);
            string three = Convert.ToString(letterThree);
            Console.WriteLine($"{letterThree}{letterTwo}{letterOne}");
        }
    }
}
