namespace _6.String_Matrix_Rotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            string pattern = @"Rotate\((\d*)\)";
            var rotation = Console.ReadLine();
            var regex = new Regex(pattern);
            var matches = regex.Matches(rotation);
            var degres = 0;
            foreach (Match degree in matches)
            {
                degres = int.Parse(degree.Groups[1].Value);
            }
            var rotations = (degres / 90)%4;
            var entry = Console.ReadLine();
            var stringList = new List<string>();
            while (entry != "END")
            {
                stringList.Add(entry);
                entry = Console.ReadLine();
            }
            //cases 90 and 270
            var matrix = new char[stringList.Count][];
            var longestWord = stringList.Max(x => x.Length);
            for (int i = 0; i < stringList.Count; i++)
            {
                matrix[i] = stringList[i].PadRight(longestWord).ToCharArray();
            }

            if (rotations == 1)
            {
                for (int i = 0; i < rotations; i++)
                { 
                    matrix = Rotate(matrix);
                }
                foreach (var line in matrix)
                {
                    Console.WriteLine(string.Join("",line));
                }
            }
            else if (rotations == 2)
            {
                stringList.Reverse();
                foreach (var item in stringList)
                {
                    var reverseString = item.ToCharArray();
                    Array.Reverse(reverseString);
                    Console.WriteLine(reverseString);
                }
            }
            else if (rotations==3)
            {
                for (int i = 0; i < rotations; i++)
                {
                    matrix = Rotate(matrix);
                }
                foreach (var line in matrix)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                foreach (var item in stringList)
                {
                    Console.WriteLine(item);
                }
            }            
        }
        private static char[][] Rotate(char[][] matrix)
        {
            var newMatrix = new char[matrix.Max(w => w.Length)][];

            for (int row = 0; row < newMatrix.Length; row++)
            {
                newMatrix[row] = new char[matrix.Length];

                for (int col = 0; col < newMatrix[row].Length; col++)
                {
                    newMatrix[row][col] = matrix[matrix.Length - 1 - col][row];
                }
            }
            return newMatrix;
        }
    }
}
