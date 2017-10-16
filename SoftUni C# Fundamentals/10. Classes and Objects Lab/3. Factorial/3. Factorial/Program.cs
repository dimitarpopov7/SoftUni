namespace _3.Factorial
{
    using System;
    using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger facOfNum = num;
            for (int i = num-1; i > 1; i--)
            {
                facOfNum = facOfNum * i;
            }
            Console.WriteLine(facOfNum);
        }
    }
}
