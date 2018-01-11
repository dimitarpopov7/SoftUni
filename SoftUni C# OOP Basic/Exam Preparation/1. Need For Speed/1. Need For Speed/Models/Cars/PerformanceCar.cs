namespace _1.Need_For_Speed
{
    using System;
    using System.Collections.Generic;
    public class PerformanceCar : Car
    {
        private const int incHP = 150;
        private const int decSus = 75;
        private List<string> addOns;

        public List<string> AddOns
        {
            get { return this.addOns; }
            set { this.addOns = value; }
        }

        public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability, List<string> addOns=null) : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
        {
            this.HorsePower = this.HorsePower * incHP / 100;
            this.Suspension = this.Suspension * decSus / 100;
            this.AddOns = new List<string>();
        }
        public override void TuneCar(int tuneIndex, string addOn)
        {
            base.TuneCar(tuneIndex, addOn);
            this.AddOns.Add(addOn);
        }
        public override string ToString()
        {
            var addOnsToAddIfAny = this.addOns.Count == 0
                ? "Add-ons: None"
                : $"Add-ons: {string.Join(", ", this.addOns)}";

            return $"{base.ToString()}{Environment.NewLine}{addOnsToAddIfAny}";
        }
    }
}