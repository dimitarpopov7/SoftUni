namespace _9.Google
{
    using System.Collections.Generic;
    public class Person
    {
        private string company;
        private double salary;
        private string name;
        private string car;
        private HashSet<string> parent;
        private HashSet<string> pokemon;
        private HashSet<string> children;
        public Person(string name, string car, string company, double salary)
        {
            this.name = name;
            this.car = car;
            this.company = company;
            this.salary = salary;
        }
        public HashSet<string> Parents
        {
            get { return this.parent; }
            set { this.parent = value; }
        }
        public HashSet<string> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }
        public HashSet<string> Pokemons
        {
            get { return this.pokemon; }
            set { this.pokemon = value; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public string Comapny
        {
            get { return this.company; }
            set { this.company = value; }
        }
        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public string Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

    }
}