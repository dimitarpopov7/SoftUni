namespace _3._2x2_Square_Matrix
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();
            var matrix = new char[dimensions[0]][];
            for (int i = 0; i < dimensions[0]; i++)
            {
                matrix[i] = new char[dimensions[1]];
                var line = Console.ReadLine().Split().ToList();
                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i][j] = Convert.ToChar(line[j]);
                }
            }
            int count = 0;
            for (int row = 0; row < dimensions[0]-1; row++)
            {
                for (int col = 0; col < dimensions[1]-1; col++)
                {
                    if(    matrix[row][col]==matrix[row+1][col]
                        && matrix[row][col]==matrix[row][col+1]
                        && matrix[row][col] == matrix[row + 1][col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
