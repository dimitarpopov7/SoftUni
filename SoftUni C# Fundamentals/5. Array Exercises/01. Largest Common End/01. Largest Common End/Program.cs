using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    public class Program
    {
        public static void Main()
        {
            string[] text1 = Console.ReadLine().Split(' ');
            string[] text2 = Console.ReadLine().Split(' ');
            int count = 0;

            for (int i = 0; i < Math.Max(text1.Length, text2.Length); i++)
            {
                if (text1[i] == text2[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            Array.Reverse(text1);
            Array.Reverse(text2);

            for (int i = 0; i < Math.Max(text1.Length, text2.Length); i++)
            {
                if (text1[i] == text2[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
