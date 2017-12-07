namespace _04.Cubic_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var listOfRegions = new Dictionary<string, Dictionary<string, long>>();
            var benchmark = 1000000;
            while (input!="Count em all")
            {               
                var information = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = information[0];
                var color = information[1];
                var size = int.Parse(information[2]);
                if (!listOfRegions.ContainsKey(name))
                {
                    var currentColor = new Dictionary<string, long>() { { "Black", 0L },{"Green",0L },{"Red",0L } };                    
                    currentColor[color] += size;                    
                    listOfRegions[name] = currentColor;
                    listOfRegions = Rearange(listOfRegions, name, benchmark);
                }
                else
                {
                    if (listOfRegions[name].ContainsKey(color))
                    {
                        listOfRegions[name][color]+=size;
                        listOfRegions = Rearange(listOfRegions, name, benchmark);
                    }
                    else
                    {
                        listOfRegions[name].Add(color,size);
                        listOfRegions = Rearange(listOfRegions,name,benchmark);                        
                    }
                }
                input = Console.ReadLine();                
            }
            Print(listOfRegions);
        }

        private static void Print(Dictionary<string, Dictionary<string, long>> listOfRegions)
        {
            foreach (var region in listOfRegions.OrderByDescending(r=>r.Value["Black"]).ThenBy(r=>r.Key.Length).ThenBy(x=>x.Key))
            {
                Console.WriteLine(region.Key);
                foreach (var color in region.Value.OrderByDescending(m=>m.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"-> {color.Key} : {color.Value}");
                }
            }
        }

        private static Dictionary<string, Dictionary<string, long>> Rearange(Dictionary<string, Dictionary<string, long>> listOfRegions, string name, long benchmark)
        {
            if (listOfRegions[name]["Green"] >= benchmark)
            {
                listOfRegions[name]["Red"] += listOfRegions[name]["Green"] / benchmark;
                listOfRegions[name]["Green"] = listOfRegions[name]["Green"] % benchmark;
            }
            if (listOfRegions[name]["Red"] >= benchmark)
            {
                listOfRegions[name]["Black"] += listOfRegions[name]["Red"] / benchmark;
                listOfRegions[name]["Red"] = listOfRegions[name]["Red"] % benchmark;
            }
            return listOfRegions;
        }
    }
}