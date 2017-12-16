namespace _6.TargetPractice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var row = dimensions[0];
            var col = dimensions[1];
            var entry = Console.ReadLine().ToCharArray();
            var word = new Queue<char>(entry);
            var matrix = new char[row][];
            matrix = BuildMatrix(matrix, row, col, word);
            var shotRange = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var bulletRow = shotRange[0];
            var bulletCol = shotRange[1];
            var bulletRange = shotRange[2];
            matrix = AfterShooting(matrix, bulletRow, bulletCol, bulletRange);
            Console.WriteLine(string.Join(Environment.NewLine+Environment.NewLine, matrix.Select(r => string.Join("  ", r))));
        }

        private static char[][] AfterShooting(char[][] matrix, int bulletRow, int bulletCol, int bulletRange)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    if (SnakeIsShooted(matrix, row, col, bulletRow, bulletCol, bulletRange))
                    {
                        matrix[row][col] = ' ';
                    }
                }
            }
            for (int col = 0; col < matrix[0].Length; col++)
            {
                for (int row = matrix.Length - 1; row > 0; row--)
                {
                    if (matrix[row][col] == ' ' && matrix[row - 1][col] != ' ')
                    {
                        RemainingsFallDown(matrix, row, col);
                    }
                }
            }
            return matrix;
        }

        private static char[][] RemainingsFallDown(char[][] matrix, int row, int col)
        {
            while (row < matrix.Length)
            {
                if (matrix[row][col] == ' ')
                {
                    var temp = matrix[row - 1][col];
                    matrix[row - 1][col] = matrix[row][col];
                    matrix[row][col] = temp;
                    row++;
                }
                else
                {
                    return matrix;
                }

            }
            return matrix;
        }

        private static bool SnakeIsShooted(char[][] matrix, int row, int col, int bulletRow, int bulletCol, int bulletRange)
        {
            var distance = Math.Sqrt(Math.Pow((row - bulletRow), 2) + Math.Pow((col - bulletCol), 2));
            return distance <= bulletRange;
        }

        private static char[][] BuildMatrix(char[][] matrix, int row, int col, Queue<char> word)
        {
            for (int i = 0; i < row; i++)
            {
                matrix[i] = new char[col];
            }
            int populate = 1;
            for (int i = row - 1; i >= 0; i--)
            {
                if (populate % 2 != 0)
                {
                    for (int j = col - 1; j >= 0; j--)
                    {
                        var tempLetter = word.Dequeue();
                        word.Enqueue(tempLetter);
                        matrix[i][j] = tempLetter;
                    }
                }
                else if (populate % 2 == 0)
                {
                    for (int j = 0; j < col; j++)
                    {
                        var tempLetter = word.Dequeue();
                        word.Enqueue(tempLetter);
                        matrix[i][j] = tempLetter;
                    }
                }
                populate++;
            }
            return matrix;
        }
    }
}