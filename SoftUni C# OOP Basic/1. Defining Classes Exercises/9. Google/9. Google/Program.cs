namespace _9.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine();
            var people = new List<Person>();
            while (entry != "End")
            {
                var name = string.Empty;
                var comapnyName = string.Empty;
                var car = string.Empty;
                var pokemon = string.Empty;
                var parent = string.Empty;
                var child = string.Empty;
                double salary = 0;
                if (entry.Contains("parents"))
                {
                    var info = entry.Split().ToList();
                    name = info[0];
                    parent = ($"{info[2]} {info[3]}");
                }
                else if (entry.Contains("pokemon"))
                {
                    var info = entry.Split().ToList();
                    name = info[0];
                    pokemon = ($"{info[2]} {info[3]}");
                }
                else if (entry.Contains("car"))
                {
                    var info = entry.Split().ToList();
                    name = info[0];
                    car = ($"{info[2]} {info[3]}");
                }
                else if (entry.Contains("company"))
                {
                    var info = entry.Split().ToList();
                    name = info[0];
                    comapnyName = ($"{info[2]} {info[3]}");
                    salary = double.Parse(info[4]);

                }
                else if (entry.Contains("children"))
                {
                    var info = entry.Split().ToList();
                    name = info[0];
                    child = $"{info[2]} {info[3]}";
                }
                int n = -1;
                n = people.FindIndex(x => x.Name == name);
                if (n > -1)
                {
                    var parents = people[n].Parents;
                    if (parent != string.Empty)
                    {
                        parents.Add(parent);
                    }
                    var pokemonCollection = people[n].Pokemons;
                    if (pokemon != string.Empty)
                    {
                        pokemonCollection.Add(pokemon);
                    }
                    var childs = people[n].Children;
                    if (child != string.Empty)
                    {
                        childs.Add(child);
                    }
                    if (comapnyName != string.Empty)
                    {
                        people[n].Comapny = comapnyName;
                        people[n].Salary = salary;
                    }
                    if (car != string.Empty)
                    {
                        people[n].Car = car;
                    }                    
                    people[n].Children = childs;
                    people[n].Parents = parents;
                    people[n].Pokemons = pokemonCollection;
                }
                else if (n == -1)
                {
                    var currenPerson = new Person(name, car, comapnyName, salary);
                    var parents = new HashSet<string>();
                    if (parent != string.Empty)
                    {
                        parents.Add(parent);
                    }
                    currenPerson.Parents = (parents);
                    var pokemons = new HashSet<string>();
                    if (pokemon != string.Empty)
                    {
                        pokemons.Add(pokemon);
                    }
                    currenPerson.Pokemons = pokemons;
                    var childs = new HashSet<string>();
                    if (child != string.Empty)
                    {
                        childs.Add(child);
                    }
                    currenPerson.Children = childs;
                    people.Add(currenPerson);
                }
                entry = Console.ReadLine();
            }
            var nameToSearch = Console.ReadLine();
            foreach (var person in people.Where(x=>x.Name==nameToSearch))
            {
                Console.WriteLine(person.Name);
                Console.WriteLine($"Compnay: {person.Comapny} {person.Salary:f2}");
                Console.WriteLine($"Car:{Environment.NewLine}{person.Car}");
                Console.WriteLine($"Pokemon: {Environment.NewLine}{string.Join(Environment.NewLine, person.Pokemons)}");
                Console.WriteLine($"Parents:{Environment.NewLine}{string.Join(Environment.NewLine, person.Parents)}");
                Console.WriteLine($"Children{Environment.NewLine}{string.Join(Environment.NewLine, person.Children)}");
            }
        }
    }
}