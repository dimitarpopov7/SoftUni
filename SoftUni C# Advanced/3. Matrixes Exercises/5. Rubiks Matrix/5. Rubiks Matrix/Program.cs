namespace _5.Rubiks_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Program
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();
            var matrix = new int[dimensions[0]][];
            var startNum = 1;
            for (int i = 0; i < dimensions[0]; i++)
            {
                matrix[i] = new int[dimensions[1]];
                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i][j] = startNum;
                    startNum++;
                }
            }
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split().ToList();                
                matrix = RearangeMatrix(matrix,int.Parse(command[0]),command[1],int.Parse(command[2]));                 
            }
            Console.WriteLine(BringBackMatrix(matrix, dimensions));
        }
        private static string BringBackMatrix(int[][] matrix,List<int> dimensions)
        {
            var sb = new StringBuilder();
            var expectedNum = 1;
            for (int row = 0; row < dimensions[0]; row++)
            {
                for (int col = 0; col < dimensions[1]; col++)
                {
                    if (matrix[row][col] != expectedNum)
                    {
                        sb.Append(Swap(matrix, row, col, expectedNum));
                        sb.Append(Environment.NewLine);
                    }
                    else
                    {
                        sb.Append("No swap required");
                        sb.Append(Environment.NewLine);
                    }
                    expectedNum++;
                }
            }
            return sb.ToString();
        }
        private static string Swap(int[][] matrix, int row, int col, int expectedNum)
        {
            for (int i = row; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == expectedNum)
                    {
                        matrix[i][j]=matrix[row][col];
                        matrix[row][col]=expectedNum;
                        return $"Swap ({row}, {col}) with ({i}, {j})";
                    }
                }
            }
            return string.Empty;
        }
        private static int[][] RearangeMatrix(int[][] matrix, int rowOrCol, string direction, int move)
        {
            if (direction == "down" || direction == "up")
            {
                matrix = MoveCol(matrix, rowOrCol, direction, move);
            }
            else
            {
                matrix = MoveRow(matrix, rowOrCol, direction, move);
            }
            return matrix;
        }

        private static int[][] MoveRow(int[][] matrix, int rowOrCol, string direction, int move)
        {
            var rowQue = new Queue<int>(matrix[rowOrCol]);
            if (direction == "left")
            {
                for (int i = 0; i <move%matrix.Length; i++)
                {
                    var num=rowQue.Dequeue();
                    rowQue.Enqueue(num);
                }
            }
            else
            {                
                for (int i = 0; i < matrix.Length-move%matrix.Length; i++)
                {
                    var num = rowQue.Dequeue();
                    rowQue.Enqueue(num);
                }
            }
            matrix[rowOrCol] = rowQue.ToArray();
            return matrix;
        }
        private static int[][] MoveCol(int[][] matrix, int rowOrCol, string direction, int move)
        {
            var colQue = new Queue<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                colQue.Enqueue(matrix[i][rowOrCol]);
            }            
            if (direction == "up")
            {
                for (int i = 0; i < move % matrix.Length; i++)
                {
                    var num = colQue.Dequeue();
                    colQue.Enqueue(num);
                }
            }
            else if(direction=="down")
            {
                for (int i = 0; i < matrix.Length - move % matrix.Length; i++)
                {
                    var num = colQue.Dequeue();
                    colQue.Enqueue(num);
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][rowOrCol] = colQue.Dequeue();
            }            
            return matrix;
        }
    }
}