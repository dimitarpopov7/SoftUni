namespace _01.Convert_from_base_10_to_base_N
{
    using System;
    using System.Linq;
    using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split(' ').Select(x=>BigInteger.Parse(x)).ToList();
            BigInteger number = entry[1];
            BigInteger system = entry[0];
            string result = string.Empty;
            while (number>0)
            {
                BigInteger afterDiv = number % system;
                number = number / system;
                result = afterDiv.ToString()+result;
            }
            Console.WriteLine(result);
        }
    }
}
