namespace _2.Knights_of_Honor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            var entry = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Action<List<string>> printSirs=PrintSir;
            printSirs(entry);
        }
        private static void PrintSir(List<string> namesToHonor)
        {
            foreach (var name in namesToHonor)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
