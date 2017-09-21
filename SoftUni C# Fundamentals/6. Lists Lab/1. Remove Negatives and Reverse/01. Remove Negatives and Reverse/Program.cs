using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    public class Program
    {
        public static void Main()
        {
            List<int> listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            listOfNumbers.Reverse();
            listOfNumbers.RemoveAll(x => x < 0);
            if (listOfNumbers.Count > 0)
            {
                for (int i = 0; i < listOfNumbers.Count; i++)
                {
                    Console.Write(listOfNumbers[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
