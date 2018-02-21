namespace _11.Inferno_Infinity.Models
{
    using System;
    using Enums;
    public abstract class Gem
    {
        private int strenght;
        private int agility;
        private int vitality;
        GemClarity clarity;
        public Gem(string clarity)
        {
            this.Clarity = (GemClarity)Enum.Parse(typeof(GemClarity), clarity);
            this.Strenght = (int)this.Clarity;
            this.Agility = (int)this.Clarity;
            this.Vitality = (int)this.Clarity;
        }

        public int Strenght
        {
            get { return this.strenght; }
            protected set { this.strenght = value; }
        }
        public int Agility
        {
            get { return this.agility; }
            protected set { this.agility = value; }
        }
        public int Vitality
        {
            get { return this.vitality; }
            protected set { this.vitality = value; }
        }
        public GemClarity Clarity
        {
            get { return this.clarity; }
            private set { this.clarity = value; }
        }
    }
}
