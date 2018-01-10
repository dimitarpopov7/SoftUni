namespace _3.Wind_Farm
{
    using System;
    public  class FoodFactory
    {
        public static Food GetFood(string type, int quantity)
        {
            switch (type)
            {
                case "Vegetable":
                    return new Vegitable(quantity);
                case "Meat":
                    return new Meat(quantity);
                default:
                    throw new ArgumentException("Invalid Food.");
            }
        }
    }
}