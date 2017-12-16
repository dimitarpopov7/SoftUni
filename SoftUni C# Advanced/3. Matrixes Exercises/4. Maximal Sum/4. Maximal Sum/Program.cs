namespace _4.Maximal_Sum
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();
            var matrix = new int[dimensions[0]][];
            for (int i = 0; i < dimensions[0]; i++)
            {
                matrix[i] = new int[dimensions[1]];
                var line = Console.ReadLine().Split(new[] { " "},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i][j] = line[j];
                }
            }
            var sum3X3 = 0;
            var rowIndex = 0;
            var colIndex = 0;
            for (int row = 0; row < dimensions[0]-2; row++)
            {
                for (int col = 0; col < dimensions[1]-2; col++)
                {
                    var tempSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2]
                          + matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2]
                          + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                    if (tempSum > sum3X3)
                    {
                        sum3X3 = tempSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum3X3}");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[rowIndex+i].Skip(colIndex).Take(3)));
            }
        }
    }
}