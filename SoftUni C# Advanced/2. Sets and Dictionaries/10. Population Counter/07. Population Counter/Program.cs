namespace _07.Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var countriesCitiesPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var entry = Console.ReadLine().Split('|').ToList();
                if (entry[0] == "report")
                {
                    break;
                }
                var countryName = entry[1];
                var cityName = entry[0];
                var cityPopulation = int.Parse(entry[2]);

                var cityAndPopulation = new Dictionary<string, long>();

                if (!countriesCitiesPopulation.ContainsKey(countryName))
                {
                    cityAndPopulation[cityName] = cityPopulation;
                    countriesCitiesPopulation[countryName] = cityAndPopulation;
                }
                else
                {
                    cityAndPopulation = countriesCitiesPopulation[countryName];
                    if (cityAndPopulation.ContainsKey(cityName))
                    {
                        cityAndPopulation[cityName] += cityPopulation;
                    }
                    else
                    {
                        countriesCitiesPopulation[countryName].Add(cityName, cityPopulation);
                    }
                }
            }
            foreach (var country in countriesCitiesPopulation.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var sumOfCities = country.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{country.Key} (total population: {sumOfCities.Sum()})");
                Console.Write($"=>{string.Join("=>", country.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}


