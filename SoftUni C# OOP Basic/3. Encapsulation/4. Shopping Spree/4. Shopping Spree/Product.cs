namespace _4.Shopping_Spree
{
    using System;
    public class Product
    {
        private string name;
        private int cost;
        public Product(string name, int cost)
        {
            this.name = name;
            this.Cost = cost;
        }
        public string Name => this.name;
        public int Cost
        {
            get { return this.cost; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.cost = value;
            }
        }
    }
}