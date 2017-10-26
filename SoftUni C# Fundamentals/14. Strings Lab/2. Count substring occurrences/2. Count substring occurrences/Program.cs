namespace _2.Count_substring_occurrences
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            var index = 0;
            var count = 0;

            while (true)
            {
                var find = text.IndexOf(pattern,index);
                if (find >= 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                index = find+1;
            }
            Console.WriteLine(count);

        }
    }
}
