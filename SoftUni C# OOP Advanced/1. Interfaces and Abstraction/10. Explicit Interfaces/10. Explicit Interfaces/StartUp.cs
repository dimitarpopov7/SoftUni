namespace _10.Explicit_Interfaces
{
    using System;
    using System.Linq;

    public interface IResident
    {
        string Name { get; }
        string County { get; }
        string GetName();
    }
    public interface IPerson
    {
        string Name { get; }
        int Age { get; }
        string GetName();
    }
    public class Citizen : IResident, IPerson
    {
        public string Name { get; private set; }
        
        public int Age { get; private set; }

        public string County { get; private set; }

        public Citizen(string name)
        {
            this.Name = name;
        }

        string IPerson.GetName()
        {
            return $"{this.Name}";
        }
        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
    }
    public class StartUp
    {
        public static void Main()
        {
            var info = Console.ReadLine().Split().ToList();
            
            while (info[0]!="End")
            {
                var name = info[0];
                IResident currentResident = new Citizen(name);
                IPerson currenPerson = new Citizen(name);
                Console.WriteLine(currenPerson.GetName());
                Console.WriteLine(currentResident.GetName());
                info = Console.ReadLine().Split().ToList();
            }
        }
    }
}
