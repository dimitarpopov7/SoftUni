namespace _3.Wind_Farm
{
    public abstract class Animal
    {
        public string AnimalName {get;set;}
        public string AnimalType { get; set; }
        public double AnimalWeight { get; set; }
        public int FoodEaten { get; set; }
        public abstract void MakeSound();
        public abstract void Eat(Food food);
        public Animal(string animalName,string animalType,double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;            
        }
        public override string ToString()
        {
            return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.FoodEaten}]";
        }
    }
}