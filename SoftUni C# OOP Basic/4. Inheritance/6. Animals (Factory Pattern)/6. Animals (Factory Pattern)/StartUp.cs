namespace _6.Animals__Factory_Pattern_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var type = Console.ReadLine();
            var animals = new List<Animal>();
            while (type != "Beast!")
            {
                var animalInfo = Console.ReadLine().Split().ToList();
                var name = animalInfo[0];
                var age = int.Parse(animalInfo[1]);
                string gender = null;
                if (animalInfo.Count > 2)
                {
                    gender = animalInfo[2];
                }
                try
                {
                    var currentAnimal=AnimalFactory.GetAnimal(type, name, age, gender);
                    animals.Add(currentAnimal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                type = Console.ReadLine();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}