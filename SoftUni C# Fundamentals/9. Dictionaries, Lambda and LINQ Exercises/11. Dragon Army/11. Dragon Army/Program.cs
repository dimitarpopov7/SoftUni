namespace _11.Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string type = string.Empty;
            string name = string.Empty;
            double health = 0;
            double damage = 0;
            double armor = 0;

            var types = new Dictionary<string, SortedDictionary<string,List<double>>>();
            var names = new SortedDictionary<string, List<double>>();
            var list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                //Reset
                type = string.Empty;
                name = string.Empty;
                health = 0;
                damage = 0;
                armor = 0;
                list = new List<double>();
                names = new SortedDictionary<string, List<double>>();                
                //Record characteristics
                var entry = Console.ReadLine().Split(' ').ToList();
                type = entry[0];
                name = entry[1];
                try
                {
                    damage = Convert.ToInt32(entry[2]);
                }
                catch (Exception)
                {

                    damage = 45 ;
                }
                try
                {
                    health = Convert.ToInt32(entry[3]);
                }
                catch (Exception)
                {

                    health = 250;
                }
                try
                {
                    armor = Convert.ToInt32(entry[4]);
                }
                catch (Exception)
                {

                    armor = 10;
                }
                list.Add(damage);
                list.Add(health);
                list.Add(armor);
                if (!types.ContainsKey(type))
                {
                    names[name] = list;
                    types[type] = names;
                }
                else
                {
                    names = types[type];
                    if (!names.ContainsKey(name))
                    {                        
                        names.Add(name,list);
                        types[type]= names;
                    }
                    else
                    {
                        names[name] = list;
                        types[type]=names;
                    }
                }
            }
            //Printing out
            foreach (var color in types)
            {            
                double avrgDmg = color.Value.Select(x => x.Value[0]).Average();
                double avrgHealth = color.Value.Select(x => x.Value[1]).Average();
                double avrgArm = color.Value.Select(x => x.Value[2]).Average();
                Console.WriteLine($"{color.Key}::({avrgDmg:f2}/{avrgHealth:f2}/{avrgArm:f2})");
                foreach (var drag in color.Value)
                {
                    Console.WriteLine($"-{drag.Key} -> damage: {drag.Value[0]}, health: {drag.Value[1]}, armor: {drag.Value[2]}");
                }
            }
        }
    }
}

