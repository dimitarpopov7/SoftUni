namespace _1.Generic_Box
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public static class SolutionManager
    {
        public static void GenericBox()
        {
        }
        internal static void BoxOfString()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string entry = Console.ReadLine();
                var boxString = new Box<string>(entry);
                Console.WriteLine(boxString.ToString()); 
            }
        }
        internal static void BoxOfIntegers()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int entry = int.Parse(Console.ReadLine());
                var boxString = new Box<int>(entry);
                Console.WriteLine(boxString.ToString());
            }
        }
        internal static void SwapMethodStrings()
        {
            int n = int.Parse(Console.ReadLine());
            var listOfStrings = new List<Box<string>>();
            for (int i = 0; i <n; i++)
            {
                string input = Console.ReadLine();
                listOfStrings.Add(new Box<string>(input));
            }
            var indexesToSwap = Console.ReadLine().Split().Select(int.Parse).ToList();
            int firstIndex = indexesToSwap[0];
            int secondIndex = indexesToSwap[1];
            Swap(listOfStrings, firstIndex, secondIndex);
            foreach (var item in listOfStrings)
            {
                Console.WriteLine(item);
            }
        }
        internal static void SwapMethodIntegers()
        {
            int n = int.Parse(Console.ReadLine());
            var listOfIntegers = new List<Box<int>>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                listOfIntegers.Add(new Box<int>(input));
            }
            var indexesToSwap = Console.ReadLine().Split().Select(int.Parse).ToList();
            int firstIndex = indexesToSwap[0];
            int secondIndex = indexesToSwap[1];
            Swap(listOfIntegers, firstIndex, secondIndex);
            foreach (var item in listOfIntegers)
            {
                Console.WriteLine(item);
            }
        }
        internal static void CountMethodString()
        {
            var stringBoxes = new List<Box<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                stringBoxes.Add(new Box<string>(Console.ReadLine()));
            }
            var comparableBox = new Box<string>(Console.ReadLine());
            Console.WriteLine(CompareElements(stringBoxes, comparableBox));
        }
        internal static void CountMethodDouble()
        {
            var stringBoxes = new List<Box<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                stringBoxes.Add(new Box<double>(double.Parse(Console.ReadLine())));
            }
            var comparableBox = new Box<double>(double.Parse(Console.ReadLine()));
            Console.WriteLine(CompareElements(stringBoxes, comparableBox));
        }
        private static int CompareElements<T>(List<Box<T>> collection, Box<T> compareTo)
            where T:IComparable<T>
        {
            var count = collection.Count(b => b.Value.CompareTo(compareTo.Value) > 0);
            return count;
        } 
        private static IList Swap(IList collection, int firstIndex,int secondIndex)
        {
            var firstItem = collection[firstIndex];
            var secondItem = collection[secondIndex];
            collection[firstIndex] = secondItem;
            collection[secondIndex] = firstItem;
            return collection;
        }
    }
}