using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] array = values.Split(' ');
            int[] arr = new int[array.Length];
            bool contains = false;
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = int.Parse(array[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        contains = true;
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");
                    }
                }
            }
            if (contains == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
