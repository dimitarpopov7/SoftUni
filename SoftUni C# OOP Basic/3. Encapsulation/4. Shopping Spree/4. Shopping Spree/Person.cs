namespace _4.Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    public class Person
    {
        private string name;
        private int money;
        public List<Product> bagOfProducts { get; set; }
        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value; 
            }
        }
        public int Money
        {
            get { return this.money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public void BuyProduct(Product product)
        {
            
            if (this.Money-product.Cost < 0)
            {
                throw new ArgumentException($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                this.Money -= product.Cost;
                this.bagOfProducts.Add(product);
                throw new ArgumentException($"{this.name} bought {product.Name}");
            }
        }
    }
}