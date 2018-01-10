namespace _3.Wind_Farm
{
    using System;
    public class Cat : Felime
    {
        public string Breed { get; set; }

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion,string breed) : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }
        public override string ToString()
        {
            return $"{this.AnimalType}[{base.AnimalName}, {this.Breed}, {base.AnimalWeight}, {this.LivingRegion}, {base.FoodEaten}]";
        }
    }
}