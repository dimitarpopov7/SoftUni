namespace _6.Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public interface IBirthDayAble
    {
        string BirthDay { get; }
    }
    public interface IId
    {
        string ID { get; }
    }
    public class Human : IId, IBirthDayAble
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        public string BirthDay { get; private set; }

        public Human(string name, int age, string id,string birthDay)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.BirthDay = birthDay;
        }
    }
    public class Pet : IBirthDayAble
    {
        public string BirthDay { get; private set; }
        public string Name { get; private set; }
        public Pet(string name,string birthDay)
        {
            this.BirthDay = birthDay;
            this.Name = name;
        }
    }
    public class Robot : IId
    {
        public string ID { get; private set; }
        public string Model { get; set; }
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
            var citizensList = new List<IBirthDayAble>();
            while (entry[0] != "End")
            {
               if (entry[0]=="Citizen")
                {
                    var currentCitizen = new Human(entry[1], int.Parse(entry[2]), entry[3],entry[4]);
                    citizensList.Add(currentCitizen);
                }
                else if (entry[0] == "Pet")
                {
                    var currentCitizen = new Pet(entry[1], entry[2]);
                    citizensList.Add(currentCitizen);
                }
                entry = Console.ReadLine().Split().ToList();
            }
            var lastDigits = Console.ReadLine();
            var rebals = new List<string>();
            foreach (var citizen in citizensList.Where(x => x.BirthDay.EndsWith(lastDigits)))
            {
                rebals.Add(citizen.BirthDay);
            }
            if (rebals.Count == 0)
            {
                Console.WriteLine("<no output>");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, rebals));
            }
        }
    }
}
