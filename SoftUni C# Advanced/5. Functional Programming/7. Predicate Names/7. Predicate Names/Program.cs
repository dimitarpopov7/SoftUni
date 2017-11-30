namespace _7.Predicate_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var allowedLenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToList();
            Predicate<string> meetsRequirement=x=>x.Length<=allowedLenght;
            var namesLeft = new List<string>();
            foreach (var name in names)
            {
                if (meetsRequirement(name))
                {
                    namesLeft.Add(name);
                }
            }
            foreach(var name in namesLeft)
            {
                Console.WriteLine(name);
            }
        }
    }
}
