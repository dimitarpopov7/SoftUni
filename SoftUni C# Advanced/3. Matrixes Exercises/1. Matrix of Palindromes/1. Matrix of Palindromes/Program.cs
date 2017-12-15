namespace _1.Matrix_of_Palindromes
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();
            var alphabet= "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var matrix = new string[dimensions[0],dimensions[1]];
            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    string text = $"{alphabet[i]}" + $"{alphabet[i + j]}" + $"{alphabet[i]}";
                    Console.Write($"{text} ");
                }
                Console.WriteLine();
            }
        }
    }
}
