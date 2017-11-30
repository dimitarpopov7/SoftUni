namespace _13.TriFunction
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var listOfNames = Console.ReadLine().Split().ToList();
            foreach (var name in listOfNames)
            {
                int sum = SumOfLetters(name);
                if (sum >= n)
                {
                    Console.WriteLine(name);
                }
            }
        }
        private static int SumOfLetters(string name)
        {
            var letters = name.ToCharArray();
            int sum = 0;
            foreach (var letter in letters)
            {
                sum += (int)letter;
            }
            return sum;
        }
    }
}
