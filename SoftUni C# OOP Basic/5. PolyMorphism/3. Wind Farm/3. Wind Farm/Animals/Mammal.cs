namespace _3.Wind_Farm
{
    public abstract class Mammal : Animal
    {
        public  string LivingRegion { get; set; }

        public Mammal(string animalName, string animalType, double animalWeight,string livingRegion) : base(animalName, animalType, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }
        public override string ToString()
        {
            return $"{this.AnimalType}[{base.AnimalName}, {base.AnimalWeight}, {this.LivingRegion}, {base.FoodEaten}]";
        }
    }   
}