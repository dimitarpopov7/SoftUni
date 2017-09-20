using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    public class Program
    {
        public static void Main()
        {
            char[] letters1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] letters2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int lenght = Math.Min(letters1.Length, letters2.Length);
            if (letters1.Length > letters2.Length)
            {
                Console.WriteLine(string.Join("", letters2));
                Console.WriteLine(string.Join("", letters1));
            }
            else if (letters2.Length > letters1.Length)
            {
                Console.WriteLine(string.Join("", letters1));
                Console.WriteLine(string.Join("", letters2));
            }
            else
            {
                {
                    for (int i = 0; i < lenght; i++)
                    {
                        if (letters1[i] == letters2[i])
                        {
                            if (i == lenght - 1)
                            {
                                Console.WriteLine(string.Join("", letters2));
                                Console.WriteLine(string.Join("", letters1));
                            }
                        }
                        else if (letters1[i] >= letters2[i])
                        {
                            Console.WriteLine(string.Join("", letters2));
                            Console.WriteLine(string.Join("", letters1));
                            break;
                        }
                        else if (letters2[i] >= letters1[i])
                        {
                            Console.WriteLine(string.Join("", letters1));
                            Console.WriteLine(string.Join("", letters2));
                            break;
                        }
                    }
                }
            }

        }
    }
}
