namespace _8.Military_Elite.Soldiers.SpecialSoldiers
{    
    using System.Collections.Generic;
    using _8.Military_Elite.Repairs;
    using Interfaces;
    using System;

    public class Engineer : SpecialSoldier, IEngineer
    {
        private List<Repair> repairs;
        public Engineer(string firstName, string lastName, string id, double salary,string corps,List<Repair> repairs) : base(firstName, lastName, id, salary,corps)
        {
            this.Repairs = repairs;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Corps: {this.Corps}{Environment.NewLine}Repairs:{$"{Environment.NewLine}  "}{string.Join($"{Environment.NewLine}  ", this.Repairs)}";
        }

        public List<Repair> Repairs
        {
            get
            {
                return this.repairs;
            }
            private set
            {
                this.repairs = value;
            }
        }
    }
}