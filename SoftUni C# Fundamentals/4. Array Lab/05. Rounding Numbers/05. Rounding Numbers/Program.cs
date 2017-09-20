using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] array = values.Split(' ');
            double[] arr = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = double.Parse(array[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => {Math.Round(arr[i], 0, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
