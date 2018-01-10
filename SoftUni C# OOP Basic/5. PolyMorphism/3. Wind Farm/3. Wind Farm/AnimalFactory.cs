namespace _3.Wind_Farm
{
    using System;
    public class AnimalFactory
    {
        public static Animal GetAninmal(string animalType,string animalName, double animalWeight, string animalLivingRegion, string catBreed = null)
        {
            switch (animalType)
            {
                case "Cat":
                    return new Cat(animalName, animalType, animalWeight,animalLivingRegion,catBreed);
                case "Tiger":
                    return new Tiger(animalName, animalType, animalWeight, animalLivingRegion);
                case "Mouse":
                    return new Mouse(animalName, animalType, animalWeight, animalLivingRegion);
                case "Zebra":
                    return new Zebra(animalName, animalType, animalWeight, animalLivingRegion);

                default:
                    throw new ArgumentException("Invalid Animal Type.");
            }
        }
    }
}