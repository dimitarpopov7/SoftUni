namespace _2.Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var setLenghts = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            var setOne = new HashSet<int>();
            var setTwo = new HashSet<int>();
            for (int i = 0; i < setLenghts[0]; i++)
            {
                var num = int.Parse(Console.ReadLine());
                setOne.Add(num);
            }
            for (int i = 0; i < setLenghts[1]; i++)
            {
                var num = int.Parse(Console.ReadLine());
                setTwo.Add(num);
            }

            Console.WriteLine(string.Join(" ",setOne.Intersect(setTwo)));
        }
    }
}
