namespace _8.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split().ToList();
            var trainersList = new List<Trainer>();
            while (entry[0] != "Tournament")
            {
                var trainerName = entry[0];
                var pokemonName = entry[1];
                var pokemonElement = entry[2];
                var pokemonHealth = int.Parse(entry[3]);
                var currentPokemon = new Pokemon(pokemonName,pokemonHealth,pokemonElement);
                int n = -1;
                n = trainersList.FindIndex(x => x.Name == trainerName);
                if (n > -1)
                {
                    var currentTrainer = trainersList[n];
                    currentTrainer.Pokemons.Add(currentPokemon);
                }
                else
                {
                    var hsPokemons = new HashSet<Pokemon>() { currentPokemon};
                    var currentTrainer = new Trainer(trainerName, hsPokemons);
                    trainersList.Add(currentTrainer);
                }
                entry = Console.ReadLine().Split().ToList();
            }
            var element = Console.ReadLine();
            while (element != "End")
            {
                foreach (var trainer in trainersList)
                {
                    var pokemonsWithSameElement = 0;
                    foreach (var pokemon in trainer.Pokemons.Where(x=>x.Element==element))
                    {
                        pokemonsWithSameElement++;
                    }
                    if (pokemonsWithSameElement == 0)
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;                            
                        }
                        if (trainer.Pokemons.Count > 0 && trainer.Pokemons.Where(p => p.Health <= 0).FirstOrDefault() != null)
                        {
                            trainer.Pokemons = new HashSet<Pokemon>(trainer.Pokemons.Where(p => p.Health > 0));
                        }
                    }
                    else
                    {
                        trainer.NumOfBadges++;
                    }
                }                
                element = Console.ReadLine();
            }
            foreach (var trainer in trainersList.OrderByDescending(t=>t.NumOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}