namespace _3.Wind_Farm
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            //{AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed} = Only if its cat]
            var animalInfo = Console.ReadLine().Split().ToList();
            while (animalInfo[0]!="End")
            {
                if (animalInfo.Count > 4)
                {
                    var cat=AnimalFactory.GetAninmal(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                    cat.MakeSound();
                    var foodInfo = Console.ReadLine().Split().ToList();
                    var currentFood = FoodFactory.GetFood(foodInfo[0], int.Parse(foodInfo[1]));
                    cat.Eat(currentFood);
                    Console.WriteLine(cat);
                }
                else
                {
                    var currentAnimal= AnimalFactory.GetAninmal(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                    currentAnimal.MakeSound();
                    var foodInfo = Console.ReadLine().Split().ToList();
                    var currentFood = FoodFactory.GetFood(foodInfo[0], int.Parse(foodInfo[1]));
                    try
                    {
                        currentAnimal.Eat(currentFood);                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine(currentAnimal);
                }
                animalInfo = Console.ReadLine().Split().ToList();
            }            
        }
    }
}