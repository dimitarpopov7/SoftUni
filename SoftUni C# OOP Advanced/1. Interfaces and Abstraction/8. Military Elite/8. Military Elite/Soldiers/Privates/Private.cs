namespace _8.Military_Elite
{
    using Interfaces;
    using System;

    public class Private : Soldier, IPrivate
    {
        private double salary;
        public Private(string firstName, string lastName, string id,double salary) : base(firstName, lastName, id)
        {
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:f2}";
        }
        public double Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }
    }
}
