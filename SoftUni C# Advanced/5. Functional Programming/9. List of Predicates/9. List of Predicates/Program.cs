namespace _9.List_of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var upperBound = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            for (int i = 1; i <= upperBound; i++)
            {
                numbers.Add(i);
            }
            var divisors = Console.ReadLine().Split().Select(int.Parse).ToList();
            foreach (var divisor in divisors)
            {
                Predicate.AddPredicate(x => x % divisor == 0);
            }
            numbers = Predicate.ApplyPredicates(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
    public static class Predicate
    {
        public static List<Func<int, bool>> predicates = new List<Func<int, bool>>();

        public static void AddPredicate(Func<int, bool> predicate)
        {
            predicates.Add(predicate);
        }
        public static List<int> ApplyPredicates(List<int> numbers)
        {
            List<int> result = new List<int>();
            bool legal = true;
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                foreach (var predicate in predicates)
                {
                    if (!predicate(currentNum))
                    {
                        legal = false;
                        break;
                    }
                }
                if (legal)
                {
                    result.Add(currentNum);
                }
                legal = true;
            }
            return result;
        }
    }    
}

