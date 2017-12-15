namespace _2.Diagonal_Difference
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new double[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[n];
                var firstLine = Console.ReadLine().Split().Select(double.Parse).ToList();
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = firstLine[j];
                }
            }
            double diagonalOne = 0;
            double diagonalTwo = 0;
            int row = 0;
            int col = 0;
            int row2 = n-1;
            int col2 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                diagonalOne += matrix[row][col];
                row++;
                col++;
                diagonalTwo += matrix[row2][col2];
                row2--;
                col2++;
            }
            Console.WriteLine(Math.Abs(diagonalOne-diagonalTwo));
        }
    }
}