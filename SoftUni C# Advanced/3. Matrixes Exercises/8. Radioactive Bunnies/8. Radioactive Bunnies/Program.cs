namespace _8.Radioactive_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();
            var matrix = new char[dimensions[0]][];
            for (int i = 0; i < matrix.Length; i++)
            {
                var line = Console.ReadLine().ToCharArray();
                matrix[i] = new char[line.Length];
                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i][j] = line[j];
                }
            }
            var commands = Console.ReadLine().ToList();
            var que = new Queue<char>(commands);
            var playerLastLocation = new Queue<int>();
            for (int i = 0; i < commands.Count; i++)
            {
                matrix = MovePlayer(matrix, que, playerLastLocation);
                matrix = MultiplyBunnies(matrix);
            }
        }

        private static char[][] MultiplyBunnies(char[][] matrix)
        {
            var bunniesLocations = new Queue<int>();
            for (int k = 0; k < matrix.Length; k++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[k][j] == 'B')
                    {
                        bunniesLocations.Enqueue(k);
                        bunniesLocations.Enqueue(j);
                    }
                }
            }
            int numOfBunnies = bunniesLocations.Count / 2;
            for (int i = 0; i < numOfBunnies; i++)
            {
                int row = bunniesLocations.Dequeue();
                int col = bunniesLocations.Dequeue();
                try
                {
                    matrix[row - 1][col] = 'B';
                }
                catch (Exception)
                {
                }
                try
                {
                    matrix[row + 1][col] = 'B';
                }
                catch (Exception)
                {
                }
                try
                {
                    matrix[row][col + 1] = 'B';
                }
                catch (Exception)
                {
                }
                try
                {
                    matrix[row][col - 1] = 'B';
                }
                catch (Exception)
                {
                }
            }
            return matrix;
        }

        private static char[][] MovePlayer(char[][] matrix, Queue<char> que, Queue<int> playerLastLocation)
        {
            var playerLocation = new Queue<int>();
            var currentCommand = que.Dequeue();
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[0].Length; col++)
                {
                    if (matrix[row][col] == 'P')
                    {
                        playerLocation.Enqueue(row);
                        playerLocation.Enqueue(col);
                    }
                }
            }
            if (playerLocation.Count == 2)
            {
                int row = playerLocation.Dequeue();
                int col = playerLocation.Dequeue();
                switch (currentCommand)
                {
                    case 'U':
                        if (!IsNotBomb(matrix, row - 1, col, currentCommand))
                        {
                            try
                            {
                                matrix[row - 1][col] = 'P';
                                matrix[row][col] = '.';
                                playerLastLocation.Enqueue(row - 1);
                                playerLastLocation.Enqueue(col);
                            }
                            catch (Exception)
                            {
                                matrix[row][col] = '.';
                                PlayerWin(matrix, row, col);
                            }
                        }
                        else
                        {
                            PlayerDead(matrix, row - 1, col);
                        }
                        break;
                    case 'L':
                        if (!IsNotBomb(matrix, row, col - 1, currentCommand))
                        {
                            try
                            {
                                matrix[row][col - 1] = 'P';
                                matrix[row][col] = '.';

                                playerLastLocation.Enqueue(row);
                                playerLastLocation.Enqueue(col - 1);
                            }
                            catch (Exception)
                            {
                                matrix[row][col] = '.';
                                PlayerWin(matrix, row, col);
                            }
                        }
                        else
                        {
                            PlayerDead(matrix, row, col - 1);
                        }
                        break;
                    case 'R':
                        if (!IsNotBomb(matrix, row, col + 1, currentCommand))
                        {
                            try
                            {
                                matrix[row][col + 1] = 'P';
                                matrix[row][col] = '.';
                                playerLastLocation.Enqueue(row + 1);
                                playerLastLocation.Enqueue(col);
                            }
                            catch (Exception)
                            {
                                matrix[row][col] = '.';
                                PlayerWin(matrix, row, col);
                            }
                        }
                        else
                        {
                            PlayerDead(matrix, row, col + 1);
                        }
                        break;
                    case 'D':
                        if (!IsNotBomb(matrix, row + 1, col, currentCommand))
                        {
                            try
                            {
                                matrix[row + 1][col] = 'P';
                                matrix[row][col] = '.';
                                playerLastLocation.Enqueue(row + 1);
                                playerLastLocation.Enqueue(col);
                            }
                            catch (Exception)
                            {
                                matrix[row][col] = '.';
                                PlayerWin(matrix, row, col);
                            }
                        }
                        else
                        {
                            PlayerDead(matrix, row + 1, col);
                        }
                        break;
                }
            }
            else
            {
                PlayerHasDiedFromBunny(matrix, playerLastLocation);
            }
            return matrix;
        }

        private static void PlayerHasDiedFromBunny(char[][] matrix, Queue<int> playerLastLocation)
        {
            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join(string.Empty, r))));
            var list = new List<int>(playerLastLocation);
            int lastRowIndex = list.Count - 2;
            int lastColIndex = list.Count - 1;
            Console.WriteLine($"dead: {list[lastRowIndex]} {list[lastColIndex]}");
            Environment.Exit(0);
            return;
        }

        private static void PlayerWin(char[][] matrix, int i, int j)
        {
            matrix = MultiplyBunnies(matrix);
            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join(string.Empty, r))));
            Console.WriteLine($"won: {i} {j}");
            Environment.Exit(0);
        }

        private static void PlayerDead(char[][] matrix, int i, int j)
        {
            matrix = MultiplyBunnies(matrix);
            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join(string.Empty, r))));
            Console.WriteLine($"dead: {i} {j}");
            Environment.Exit(0);
        }

        private static bool IsNotBomb(char[][] matrix, int row, int col, char currentCommand)
        {
            var isBomb = false;
            try
            {
                if (matrix[row][col] == 'B')
                {
                    isBomb = true;
                }
            }
            catch (Exception)
            {
                isBomb = false;
            }
            return isBomb;
        }
    }
}