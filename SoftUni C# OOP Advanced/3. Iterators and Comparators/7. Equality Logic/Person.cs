namespace _7.Equality_Logic
{
    using System;
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(Person other)
        {
            var result = this.Name.CompareTo(other.Name);
            return result == 0 ? this.Age.CompareTo(other.Age) : result;
        }
    }
}
