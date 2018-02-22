namespace _2.King_s_Gambit.Models
{
    using Interfaces;
    using System;
    public class Footman : Person
    {
        public Footman(string name, IWriter writer) : base(name, writer)
        {
            this.lives = 2;
        }

        public override void KingIsAttacked(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
