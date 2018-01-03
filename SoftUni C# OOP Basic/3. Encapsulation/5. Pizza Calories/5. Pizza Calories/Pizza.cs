namespace _5.Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private double calories;
        private int toppingsNum;
        public Pizza(string name, int toppingsNum)
        {
            this.Name = name;
            this.ToppingsNum = toppingsNum;
        }
        public Pizza(string name, int toppingsNum,Dough dough, List<Topping> toppings)
            :this(name,toppingsNum)
        {
            this.Name = name;
            this.ToppingsNum = toppingsNum;
            this.Toppings = toppings;
            this.Dough = dough;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public int ToppingsNum
        {
            get { return this.toppingsNum; }
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.toppingsNum = value;
            }
        }
        public double GetCalories(Dough dough,List<Topping> toppings)
        {
            double cals = 0;
            foreach (var topping in Toppings)
            {
                cals += topping.Calories;
            }
            cals += dough.Calories;
            return cals; 
        }
        public Dough Dough { get; set; }
        public List<Topping> Toppings { get; set; }
    }
}