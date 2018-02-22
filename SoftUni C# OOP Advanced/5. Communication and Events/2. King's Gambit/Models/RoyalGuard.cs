namespace _2.King_s_Gambit.Models
{
    using System;
    using Interfaces;
    public class RoyalGuard : Person
    {
        public RoyalGuard(string name, IWriter writer) : base(name, writer)
        {
            this.lives = 3;
        }

        public override void KingIsAttacked(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}