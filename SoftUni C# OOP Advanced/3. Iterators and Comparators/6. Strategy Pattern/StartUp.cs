namespace _6.Strategy_Pattern
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> byAge = new SortedSet<Person>(new AgeComparer());
            SortedSet<Person> byName = new SortedSet<Person>(new NameComparer());
            int numOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var currentPerson = new Person(personInfo[0], int.Parse(personInfo[1]));
                byAge.Add(currentPerson);
                byName.Add(currentPerson);
            }
            foreach (var person in byName)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
            foreach (var person in byAge)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }
    public class NameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var result = x.Name.Length.CompareTo(y.Name.Length);
            if (result ==0)
            {
                var firstChar = x.Name[0].ToString();
                var secondNameFirstChar = y.Name[0].ToString();
                result = String.Compare(firstChar, secondNameFirstChar, StringComparison.OrdinalIgnoreCase);
            }
            return result;
        }
    }
    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
