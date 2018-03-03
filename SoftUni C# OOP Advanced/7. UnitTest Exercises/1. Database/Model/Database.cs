namespace _7.UnitTest_Exercises.Model
{
    using _7.UnitTest_Exercises.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Database
    {
        private const int Capacity = 16;
        private int index = -1;
        private int[] integers;
        private HashSet<IPerson> personList;

        public Database()
        {
            this.integers = new int[Capacity];
            this.PersonList = new HashSet<IPerson>();
        }

        public Database(params int[] nums):this()
        {
            if (nums != null)
            {
                foreach (var num in nums)
                {
                    this.Add(num);
                }
            }
            else
            {
                throw new InvalidOperationException("There are no nums to add.");
            }
        }

        public void AddPeople(IPerson person)
        {
            if (PersonList.Contains(person))
            {
                throw new InvalidOperationException();
            }
            PersonList.Add(person);
        }

        public void RemovePerson(IPerson person)
        {
            PersonList.RemoveWhere(p => p.Id == person.Id && p.Username == person.Username);
        }

        public IPerson FindById(int id)
        {
            if (id <0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var newPerson = PersonList.FirstOrDefault(p => p.Id == id);
            if (newPerson == null)
            {
                throw new InvalidOperationException();
            }
            return newPerson;
        }

        public IPerson FindByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentException();
            }
            var newPerson=PersonList.FirstOrDefault(p => p.Username == username);
            if (newPerson == null)
            {
                throw new InvalidOperationException();
            }
            return newPerson;
        }

        public int Index
        {
            get { return this.index; }
            set { this.index = value; }
        }

        public HashSet<IPerson> PersonList { get => personList; set => personList = value; }

        public void Add(int numberToAdd)
        {
            index++;
            if (index >= Capacity)
            {
                throw new InvalidOperationException($"Capacity is only {Capacity}.");
            }
            integers[index] = numberToAdd;
        }

        public void Remove()
        {
            if (index != -1)
            {
                integers[index] = 0;
                index--;
            }
        }
        public int[] Fetch()
        {
            return this.integers.Take(index+1).ToArray();
        }
    }
}
