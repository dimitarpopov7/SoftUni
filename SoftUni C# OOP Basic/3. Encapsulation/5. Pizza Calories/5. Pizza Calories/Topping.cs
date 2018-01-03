namespace _5.Pizza_Calories
{
    using System;
    public class Topping
    {
        private string toppingType;
        private int weight;
        private double calories;
        public Topping(string toppingType, int weight)
        {
            this.toppingType = toppingType;
            this.Weight = weight;            
            this.Calories = calories;
        }
        public int Weight
        {
            get { return this.weight; }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range[1..50].");
                }
                this.weight = value;
            }
        }
        
        public double Calories
        {
            get { return this.calories; }
            private set
            {
                if (this.toppingType != "meat" && this.toppingType!="veggies"&&this.toppingType != "cheese" && this.toppingType != "sauce"
                    && this.toppingType != "Meat" && this.toppingType != "Veggies" && this.toppingType != "Cheese" && this.toppingType != "Sauce")
                {
                    throw new ArgumentException($"Cannot place {this.toppingType} on top of your pizza.");
                }
                else if (this.toppingType == "meat"|| this.toppingType == "Meat")
                {
                    value = 2 * 1.2 * Weight;
                }
                else if (this.toppingType == "veggies"|| this.toppingType == "Veggies")
                {
                    value = 2 * 0.8 *  weight;
                }
                else if (this.toppingType == "cheese"|| this.toppingType == "Cheese")
                {
                    value = 2 * 1.1 *  Weight;
                }
                else if (this.toppingType == "sauce"|| this.toppingType == "Sauce")
                {
                    value = 2 * .9 * Weight;
                }
                this.calories = value;
            }
        }

    }
}