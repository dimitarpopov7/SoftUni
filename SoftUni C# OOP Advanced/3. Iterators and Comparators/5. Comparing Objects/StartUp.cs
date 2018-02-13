namespace _5.Comparing_Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var listPeople=GetPerople();
            int nThPerson = int.Parse(Console.ReadLine());
            if (nThPerson < 0 || nThPerson >= listPeople.Count)
            {
                Console.WriteLine("No Matches");
                return;
            }
            var targetPerson = listPeople[nThPerson];
            var equalityCount = CountEqualPeople(targetPerson, listPeople);
            if (equalityCount <= 1)
            {
                Console.WriteLine("No matches");
                return;
            }

            var differenceEqualCount = CountDifferentPeople(targetPerson, listPeople);
            Console.WriteLine($"{equalityCount} {differenceEqualCount} {listPeople.Count}");
        }

        private static int CountDifferentPeople(Person targetPerson, List<Person> people)
        {
            var differentPeopleCount = 0;

            for (int i = 1; i < people.Count; i++)
            {
                if (people[i - 1].CompareTo(people[i]) != 0)
                {
                    differentPeopleCount++;
                }
            }

            return differentPeopleCount;
        }

        private static int CountEqualPeople(Person targetPerson, List<Person> people)
        {
            var equalityCount = 1;

            for (int i = 1; i < people.Count; i++)
            {
                if (people[i - 1].CompareTo(people[i]) == 0)
                {
                    equalityCount++;
                }
            }

            return equalityCount;
        }

        private static List<Person> GetPerople()
        {
            var personInfo = Console.ReadLine().Split().ToList();
            var listPeople = new List<Person>();
            while (personInfo[0] != "END")
            {
                var currentPerson = new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]);
                listPeople.Add(currentPerson);
                personInfo = Console.ReadLine().Split().ToList();
            }
            return listPeople;
        }
    }

    public class Person : IComparable<Person>
    {   
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
        public Person(string name,int age,string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }
        public int CompareTo(Person otherPerson)
        {
            var comparison = this.Name.CompareTo(otherPerson.Name);
            if (comparison != 0)
            {
                return comparison;
            }
            comparison = this.Age.CompareTo(otherPerson.Age);
            if (comparison != 0)
            {
                return comparison;
            }
            return this.Town.CompareTo(otherPerson.Town);
        }
    }
}
