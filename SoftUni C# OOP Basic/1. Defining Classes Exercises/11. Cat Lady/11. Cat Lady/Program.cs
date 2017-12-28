namespace _11.Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var info = Console.ReadLine();
            var cats = new List<Cat>();
            while (info != "End")
            {
                var catInfo = info.Split().ToList();
                var type = catInfo[0];
                var currentCat = new Cat(catInfo[1],type);

                if (type == "StreetExtraordinaire")
                {
                    currentCat.Dicibels = int.Parse(catInfo[2]);
                }

                else if (type == "Siamese")
                {
                    currentCat.EarSize = int.Parse(catInfo[2]);
                }
                else if (type == "Cymric")
                {
                    currentCat.FurLenght = double.Parse(catInfo[2]);
                }
                cats.Add(currentCat);
                info = Console.ReadLine();
            }
            var searchCat = Console.ReadLine();
            var neededCat = cats.FirstOrDefault(x => x.Name == searchCat);
            Console.Write($"{neededCat.Type} {neededCat.Name} ");
            switch (neededCat.Type)
            {
                case "StreetExtraordinaire":
                    Console.WriteLine(neededCat.Dicibels);
                    break;
                case "Cymric":
                    Console.WriteLine($"{ neededCat.FurLenght:f2}");
                    break;
                case "Siamese":
                    Console.WriteLine(neededCat.EarSize);
                    break;
            }
        }
    }
}