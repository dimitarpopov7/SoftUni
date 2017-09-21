using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };            
            string letters = Console.ReadLine();
            for (int i = 0; i < letters.Length; i++)
            {
                for (int r = 0; r < alphabet.Length; r++)
                {
                    if (letters[i] == alphabet[r])
                    {
                        Console.WriteLine($"{letters[i]} -> {r}");
                    }
                }
            }
        }
    }
}
