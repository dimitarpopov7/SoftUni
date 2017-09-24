using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotate = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length];
            int[] arraySum = new int[array.Length];
            for (int rot = 0; rot < rotate; rot++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[(i + array.Length - 1) % array.Length];
                }
                if (rot == 1)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        arraySum[i] = arraySum[i] + array[i] + newArray[i];
                    }
                }
                else if (rot > 1)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        arraySum[i] = arraySum[i] + newArray[i];
                    }
                }
                Array.Copy(newArray, array, array.Length);
            }
            if (rotate > 1)
            {
                Console.WriteLine(string.Join(" ", arraySum));
            }
            else
            {
                Console.WriteLine(string.Join(" ", newArray));
            }
        }
    }
}
