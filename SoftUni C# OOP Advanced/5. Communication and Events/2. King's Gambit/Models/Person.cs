namespace _2.King_s_Gambit.Models
{
    using System;
    using Interfaces;
    public abstract class Person : IPerson
    {
        private string name;
        IWriter writer;
        internal int lives;
        public Person(string name,IWriter writer)
        {
            this.Name = name;
            this.writer = writer;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }
        public abstract void KingIsAttacked(object sender, EventArgs args);
    }
}