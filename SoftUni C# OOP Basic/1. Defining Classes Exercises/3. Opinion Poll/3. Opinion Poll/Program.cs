namespace _3.Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var listPeople = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var currentPerson = Console.ReadLine().Split().ToList();
                var person = new Person(currentPerson[0], int.Parse(currentPerson[1]));
                listPeople.Add(person);
            }
            foreach (var guy in listPeople.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{guy.Name} - {guy.Age}");
            }
        }
    }
}
