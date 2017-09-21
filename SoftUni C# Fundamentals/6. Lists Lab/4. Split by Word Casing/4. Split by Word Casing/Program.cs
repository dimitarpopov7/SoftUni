using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Split_by_Word_Casing
{
    public class Program
    {
        public static void Main()
        {
            List<string> text = Console.ReadLine().Split(' ',',', ';', ':', '.', '!', '(', ')', '"', '\\', '/', '[', ']', '\'').ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].All(char.IsLower))
                {
                    lowerCase.Add(text[i]);
                }
                else if (text[i].All(char.IsUpper))
                {
                    upperCase.Add(text[i]);
                }
                else
                {
                    mixedCase.Add(text[i]);
                }
            }
            lowerCase.RemoveAll(x=>x=="");
            Console.Write("Lower-case: ");
            Console.Write(string.Join(", ", lowerCase));
            Console.WriteLine();
            Console.Write("Mixed-case: ");
            Console.Write(string.Join(", ", mixedCase));
            Console.WriteLine();
            Console.Write("Upper-case: ");
            Console.Write(string.Join(", ", upperCase));
            Console.WriteLine();
        }
    }
}
