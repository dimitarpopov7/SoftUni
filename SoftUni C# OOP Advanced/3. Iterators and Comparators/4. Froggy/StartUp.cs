namespace _4.Froggy
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var initialStones = Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var lake = new Lake(initialStones);
            Console.WriteLine(string.Join(", ",lake));
        }
    }
}