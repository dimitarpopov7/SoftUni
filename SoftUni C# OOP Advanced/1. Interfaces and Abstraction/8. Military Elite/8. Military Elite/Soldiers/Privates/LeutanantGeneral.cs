namespace _8.Military_Elite
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    public class LeutanantGeneral : Soldier,ILeutenantGeneral
    {
        List<IPrivate> privates;
        private double salary;
        public LeutanantGeneral(string firstName, string lastName, string id,double salary,List <IPrivate> privates) : base(firstName, lastName, id)
        {
            this.Privates = privates;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:f2}{Environment.NewLine}Privates:{$"{Environment.NewLine}  "}{string.Join($"{Environment.NewLine}  ",this.Privates)}";
        }
        public List<IPrivate> Privates
        {
            get { return this.privates; }
            private set
            {
                this.privates = value;
            }
        }

        public double Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }        
    }
}