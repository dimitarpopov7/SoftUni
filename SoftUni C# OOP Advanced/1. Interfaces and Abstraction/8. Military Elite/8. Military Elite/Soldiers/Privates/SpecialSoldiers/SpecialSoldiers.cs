namespace _8.Military_Elite.Soldiers
{
    using System;
    using Interfaces;
    public abstract class SpecialSoldier : Private, ISpecialSoldier
    {
        private string corps;
        public SpecialSoldier(string firstName, string lastName, string id, double salary,string corps) : base(firstName, lastName, id, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get { return this.corps; }
            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("Invalid Corps.");
                }
                this.corps = value;
            }
        }
    }
}