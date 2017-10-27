namespace _04.Character_Multiplier
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split(' ').ToList();
            var firstString = entry[0];
            var secondString = entry[1];
            int fLen = firstString.Length;
            int sLen = secondString.Length;
            int result = 0;
            if (fLen == sLen)
            {
                for (int i = 0; i < fLen; i++)
                {
                    result += firstString[i] * secondString[i];
                }
            }
            else
            {
                int minLen = Math.Min(fLen, sLen);
                int maxLen = Math.Max(fLen, sLen);
                for (int i = 0; i < minLen; i++)
                {
                    result += firstString[i] * secondString[i];
                }
                for (int j = minLen; j < maxLen; j++)
                {
                    try
                    {
                        result += firstString[j];
                    }
                    catch (Exception)
                    {
                        result += secondString[j];
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
