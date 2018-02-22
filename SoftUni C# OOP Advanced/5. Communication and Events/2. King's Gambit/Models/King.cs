namespace _2.King_s_Gambit.Models
{
    using System;
    using Interfaces;

    public class King : IPerson
    {
        public event EventHandler KingAttacked;
        private string name;
        private IWriter writer;

        public King(string name, IWriter writer)
        {
            this.Name = name;
            this.writer = writer;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public void OnKingIsAttacked()
        {
            this.writer.WriteLine($"King {this.Name} is under attack!");
            this.KingAttacked?.Invoke(this, new EventArgs());
        }
    }
}
