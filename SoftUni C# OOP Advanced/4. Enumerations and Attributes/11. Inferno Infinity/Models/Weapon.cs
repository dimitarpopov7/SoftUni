namespace _11.Inferno_Infinity.Models
{
    using Enums;
    using System;
    using System.Linq;

    public abstract class Weapon
    {
        private string name;
        private int minDmg;
        private int maxDmg;
        private WeaponRarity rarity;
        private Gem[] sockets;
        private int strength;
        private int agility;
        private int vitality;

        public Weapon(string name, string rarity)
        {
            this.Name = name;
            this.Rarity = (WeaponRarity)Enum.Parse(typeof(WeaponRarity), rarity);
            this.MinDmg = 1 * (int)this.Rarity;
            this.MaxDmg = 1 * (int)this.Rarity;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int MinDmg
        {
            get { return this.minDmg; }
            protected set { this.minDmg = value; }
        }
        public int MaxDmg
        {
            get { return this.maxDmg; }
            protected set { this.maxDmg = value; }
        }
        public WeaponRarity Rarity
        {
            get { return this.rarity; }
            protected set { this.rarity = value; }
        }
        public Gem[] Sockets
        {
            get { return this.sockets; }
            protected set { this.sockets = value; }
        }
        public int Strenght
        {
            get { return this.strength; }
            protected set { this.strength = value; }
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
        public override string ToString()
        {
            var strength = this.Sockets.Where(g => g != null).Select(g => g.Strenght).Sum();
            var agility = this.Sockets.Where(g => g != null).Select(g => g.Agility).Sum();
            var vitality = this.Sockets.Where(g => g != null).Select(g => g.Vitality).Sum();
            this.Strenght = strength;
            this.Agility = agility;
            this.Vitality = vitality;
            this.MinDmg = this.MinDmg + (this.Strenght * 2) + this.Agility;
            this.MaxDmg = this.MaxDmg + (this.Strenght * 3) + (this.Agility*4);
            return $"{this.Name}: {this.MinDmg}-{this.MaxDmg} Damage, +{this.Strenght} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";
        }
    }
}