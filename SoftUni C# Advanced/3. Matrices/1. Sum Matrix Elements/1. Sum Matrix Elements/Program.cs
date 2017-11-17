namespace _1.Sum_Matrix_Elements
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new[] { ", "},StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>int.Parse(x))
                .ToList();
            var matrix = new int[matrixSizes[0]][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();
            }
            int maxSum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                maxSum += matrix[row].Sum();
            }
            foreach (var item in matrixSizes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(maxSum);
        }
    }
}
