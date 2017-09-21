using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    public class Lists
    {
        public static void Main(string[] args)
        {
            List<string> listOfNumbers = Console.ReadLine().Split('|').ToList();
            listOfNumbers.Reverse();
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                Console.Write(listOfNumbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
