namespace _1.Reverse_Numbers_with_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            try
            {
                var numbers = Console.ReadLine()
                    .Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToList();
                var reversedNumbers = new Stack<int>();
                numbers.ForEach(x => reversedNumbers.Push(x));//Something new :)
                Console.WriteLine(string.Join(" ", reversedNumbers));
            }
            catch (Exception)
            {
                return;
            }   
        }
    }
}
