namespace _1.Reverse_String
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().ToCharArray();
            Array.Reverse(entry);
            Console.WriteLine(entry);
        }
    }
}
