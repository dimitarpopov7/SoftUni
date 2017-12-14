namespace _2.SoftUni_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var guest = Console.ReadLine();
            var guests = new SortedSet<string>();
            while (guest!="PARTY")
            {
                guests.Add(guest);
                guest = Console.ReadLine();
            }
            while (guest != "END")
            {
                guests.Remove(guest);
                guest = Console.ReadLine();
            }
            Console.WriteLine(guests.Count);
            foreach (var didNotAttend in guests.OrderBy(x=>x))
            {
                Console.WriteLine(didNotAttend);
            }
        }
    }
}
