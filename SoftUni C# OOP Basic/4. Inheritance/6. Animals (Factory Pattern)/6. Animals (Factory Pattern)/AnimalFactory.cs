namespace _6.Animals__Factory_Pattern_
{
    using System;
    public class AnimalFactory
    {
        public static Animal GetAnimal(string type,string name, int age,string gender=null)//optional operator ==null
        {
            switch (type)
            {
                case "Cat":
                    return new Cat(name,gender,age);
                case "Dog":
                    return new Dog(name, gender, age);
                case "Frog":
                    return new Frog(name, gender, age);
                case "Kitten":
                    return new Kitten(name, age);
                case "Tomcat":
                    return new Tomcat(name, age);
                default:
                    throw new ArgumentException("Invalid Input!");
            }
        }
    }
}