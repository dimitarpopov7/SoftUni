namespace _02.Convert_from_base_N_to_base_10
{
    using System;
    using System.Linq;
    using System.Numerics;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToList();
            BigInteger number = entry[1];
            BigInteger system = entry[0];
            int power = 0;
            BigInteger lastDigit = 0;
            BigInteger result = 0;
            while (number > 0)
            {
                lastDigit = number % 10;
                number = number / 10;
                result += BigInteger.Multiply((BigInteger.Pow(system,power)),lastDigit);
                power++;
            }
            Console.WriteLine(result);
        }
    }
}
