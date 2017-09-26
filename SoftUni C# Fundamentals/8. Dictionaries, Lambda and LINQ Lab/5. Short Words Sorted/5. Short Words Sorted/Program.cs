namespace _5.Short_Words_Sorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '&', '\\', '/', '!', '?', ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w=>w.Length<5)
                .OrderBy(x => x)
                .ToList();
            Console.WriteLine(string.Join(", ",words));
        }
    }
}
