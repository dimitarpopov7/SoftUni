﻿namespace _2.Multiple_Implementation
{
    using System;
    using System.Reflection;
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
    }
    public interface IIdentifiable
    {
        string Id { get; set; }
    }
    public interface IBirthable
    {
        string Birthdate { get; set; }
    }
    public class Citizen : IPerson,IIdentifiable, IBirthable
    {
        public Citizen(string name, int age,string id,string birthDay)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthDay;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get ; set; }
        public string Birthdate { get; set ; }
    }

    public class StartUp
    {
        public static void Main()
        {
            Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");
            Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");
            PropertyInfo[] properties = identifiableInterface.GetProperties();
            Console.WriteLine(properties.Length);
            Console.WriteLine(properties[0].PropertyType.Name);
            properties = birthableInterface.GetProperties();
            Console.WriteLine(properties.Length);
            Console.WriteLine(properties[0].PropertyType.Name);
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);
        }
    }
}
