namespace _09.Melrah_Shake
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string entry = Console.ReadLine();
            string removePattern = Console.ReadLine(); //take out the first and the last occurance of the pattern from the entry 
            while (entry.Contains(removePattern)&&removePattern.Length>0)
            {
                int indexFirst = entry.IndexOf(removePattern);
                int indexLast = entry.LastIndexOf(removePattern);
                Console.WriteLine("Shaked it.");
                entry = entry.Remove(indexFirst, removePattern.Length);
                entry = entry.Remove(indexLast-removePattern.Length, removePattern.Length);
                removePattern = removePattern.Remove(removePattern.Length / 2,1);
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(entry);
        }
    }
}
