namespace _8.Pokemon_Trainer
{
    using System.Collections.Generic;
    public class Trainer
    {
        private string name;
        private int numOfBadges;
        private HashSet<Pokemon> pokemons;
        public Trainer(string name,HashSet<Pokemon> pokemons)
        {
            this.name = name;
            this.numOfBadges = 0;
            this.pokemons = pokemons;        
        }
        public string Name
        {
            get { return this.name; }
        }
        public int NumOfBadges
        { 
            get { return this.numOfBadges; }
            set { this.numOfBadges = value; }
        }
        public HashSet<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }
    }
}
