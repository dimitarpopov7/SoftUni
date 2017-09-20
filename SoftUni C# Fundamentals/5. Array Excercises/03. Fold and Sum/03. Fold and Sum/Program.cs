using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrayLenght = array.Length;
            int[] arrayReverse = new int[arrayLenght / 2];
            int[] arrayMiddle = new int[arrayLenght / 2];
            int[] arraySum = new int[array.Length / 2];

            for (int i = 0; i < arrayReverse.Length / 2; i++)
            {
                arrayReverse[i] = array[arrayLenght / 4 - 1 - i];
            }
            for (int i = 0; i < arrayReverse.Length / 2; i++)
            {
                arrayReverse[arrayLenght / 4 + i] = array[arrayLenght - 1 - i];
            }
            for (int i = 0; i < arrayMiddle.Length; i++)
            {
                arrayMiddle[i] = array[array.Length / 4 + i];
            }
            for (int i = 0; i < arraySum.Length; i++)
            {
                arraySum[i] = arrayReverse[i] + arrayMiddle[i];
            }

            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}
