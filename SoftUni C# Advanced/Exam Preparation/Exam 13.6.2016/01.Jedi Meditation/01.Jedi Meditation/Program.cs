namespace _01.Jedi_Meditation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var masterQue = new Queue<string>();
            var knightQue = new Queue<string>();
            var padwanQue = new Queue<string>();
            var naduhaniteQue = new Queue<string>();
            bool yodaIsThere = false;
            var jedies = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                foreach (var jedi in input)
                {
                    jedies.Add(jedi);
                }
            }            
            if (jedies.Any(x => x.StartsWith("y")))
            {
                yodaIsThere = true;
            }
            foreach (var jedi in jedies)
            {
                if (jedi.StartsWith("m"))
                {
                    masterQue.Enqueue(jedi);
                }
                else if (jedi.StartsWith("k"))
                {
                    knightQue.Enqueue(jedi);
                }
                else if (jedi.StartsWith("p"))
                {
                    padwanQue.Enqueue(jedi);
                }
                else if (jedi.StartsWith("t") || jedi.StartsWith("s"))
                {
                    naduhaniteQue.Enqueue(jedi);
                }
            }
            if (yodaIsThere)
            {                
                Console.Write(string.Join(" ", masterQue));
                Console.Write(" ");
                Console.Write(string.Join(" ", knightQue));
                Console.Write(" ");
                Console.Write(string.Join(" ",naduhaniteQue));
                Console.Write(" ");
                Console.WriteLine(string.Join(" ", padwanQue));
            }
            else
            {
                Console.Write(string.Join(" ", naduhaniteQue));
                Console.Write(" ");
                Console.Write(string.Join(" ", masterQue));
                Console.Write(" ");
                Console.Write(string.Join(" ", knightQue));
                Console.Write(" ");                
                Console.WriteLine(string.Join(" ", padwanQue));
            }
        }
    }
}
