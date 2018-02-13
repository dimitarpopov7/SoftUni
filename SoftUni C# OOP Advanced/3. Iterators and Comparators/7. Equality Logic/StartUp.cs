namespace _7.Equality_Logic
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>(new ComparePersons());
            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var currentPerson = new Person(personInfo[0], int.Parse(personInfo[1]));
                sortedSet.Add(currentPerson);
                hashSet.Add(currentPerson);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
