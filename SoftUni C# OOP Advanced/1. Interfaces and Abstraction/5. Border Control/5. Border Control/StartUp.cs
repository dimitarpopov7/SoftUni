namespace _5.Border_Control
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public interface IId
    {
        string ID { get; }
    }
    public class Human : IId
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Human(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }
    }
    public class Robot : IId
    {
        public string ID { get; private set; }
        public string Model {get;set;}
        public Robot(string model, string id)
        {
            this.Model = model;
            this.ID = id;
        }
    }
    public class StartUp
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split().ToList();
            var citizensList = new List<IId>();
            while (entry[0]!="End")
            {                               
                if (entry.Count == 2)
                {
                    var currentCitizen = new Robot(entry[0], entry[1]);
                    citizensList.Add(currentCitizen);
                }
                else if(entry.Count==3)
                {
                    var currentCitizen = new Human(entry[0], int.Parse(entry[1]), entry[2]);
                    citizensList.Add(currentCitizen);
                }
                entry = Console.ReadLine().Split().ToList();
            }
            var lastDigits = Console.ReadLine();
            var rebals = new List<string>();
            foreach (var citizen in citizensList.Where(x=>x.ID.EndsWith(lastDigits)))
            {
                rebals.Add(citizen.ID);
            }
            Console.WriteLine(string.Join(Environment.NewLine,rebals));
        }
    }
}