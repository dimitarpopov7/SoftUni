namespace _3.Wind_Farm
{
    using System;
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }
        public override void Eat(Food food)
        {
            if(food is Meat)
            {
                throw new ArgumentException($"{this.AnimalType}s are not eating that type of food!");
            }
            else
            {
                this.FoodEaten += food.Quantity;
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }
    }
}