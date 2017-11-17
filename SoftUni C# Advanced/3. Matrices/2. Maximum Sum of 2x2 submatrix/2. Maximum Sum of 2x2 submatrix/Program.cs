namespace _2.Maximum_Sum_of_2x2_submatrix
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();
            var matrix = new int[matrixSizes[0]][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();
            }
            var maxSquareRow = 0;
            var maxSquareCol = 0;
            var maxSum = 0;
            var sumInnerMatrix = 0;
            for (int row = 0; row < matrix.Length-1; row++) 
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    sumInnerMatrix = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] + matrix[row + 1][col + 1];
                    if (maxSum < sumInnerMatrix)
                    {
                        maxSum = sumInnerMatrix;
                        maxSquareRow = row;
                        maxSquareCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol + 1]}");
            Console.WriteLine($"{matrix[maxSquareRow + 1][maxSquareCol]} {matrix[maxSquareRow + 1][maxSquareCol+1]}");
            Console.WriteLine(maxSum);
        }
    }
}
