namespace _4.Pascal_Triangle
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var pascalTriangle = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                pascalTriangle[row] = new long[row+1];
                pascalTriangle[row][0] = 1;
                pascalTriangle[row][pascalTriangle[row].Length - 1] = 1;
                if (row >= 2)
                {
                    for (int col = 1; col < pascalTriangle[row].Length-1; col++)
                    {
                        pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                    }
                }
            }
            foreach (var item in pascalTriangle)
            {
                for (int i = rows; i > 1; i--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(string.Join(" ",item));
                rows--;
            }
        }
    }
}
