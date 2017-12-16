namespace _7.Lego_Blocks
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numRows = int.Parse(Console.ReadLine());
            var matrix1 = new int[numRows][];
            var matrix2 = new int[numRows][];
            int totalElements = 0;
            for (int i = 0; i < numRows; i++)
            {
                var row = Console.ReadLine().Split(new[] { " "},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                matrix1[i] = new int[row.Count];
                for (int j = 0; j < row.Count; j++)
                {
                    matrix1[i][j] = row[j];
                }
                totalElements += row.Count;
            }
            for (int i = 0; i < numRows; i++)
            {
                var row = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Array.Reverse(row);
                matrix2[i] = new int[row.Length];
                for (int j = row.Length-1; j >= 0; j--)
                {
                    matrix2[i][j] = row[j];
                }
                totalElements += row.Length;
            }
            bool perfectMatch = false;
            for (int rotation = 0; rotation < 4; rotation++)
            {
                int combinedLength = matrix1[0].Length + matrix2[0].Length;
                
                for (int row = 0; row < matrix1.Length; row++)
                {
                    if (matrix1[row].Length + matrix2[row].Length ==combinedLength)
                    {
                        perfectMatch = true;
                    }
                    else
                    {
                        perfectMatch = false;
                        break;
                    }
                }
                if (perfectMatch)
                {
                    break;
                }
            }
            if (perfectMatch)
            {
                for (int i = 0; i < numRows; i++)
                {
                    Console.WriteLine($"[{string.Join(", ", matrix1[i].Concat(matrix2[i]))}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalElements}");
            }
        }
    }
}