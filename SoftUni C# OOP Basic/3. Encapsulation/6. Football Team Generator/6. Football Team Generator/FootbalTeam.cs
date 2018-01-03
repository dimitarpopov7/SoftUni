namespace _6.Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    public class FootbalTeam
    {
        private string name;
        public List<Player> Players { get; set; }        
        public FootbalTeam(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                this.name = value ?? throw new ArgumentException("A name should not be empty.");
            }
        }
        public double GetAverageRating()
        {
            double rating = 0;
            if (this.Players.Count == 0)
            {
                rating = 0;
            }
            else
            {
                foreach (var player in this.Players)
                {
                    rating += player.Average;
                }
                rating=Math.Round(rating)/Players.Count;
            }            
            return rating;
        }        
    }
}
