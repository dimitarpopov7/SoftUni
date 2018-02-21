namespace _11.Inferno_Infinity.Models.Weapons
{
    public class Knife : Weapon
    {
        public Knife(string name, string rarity) : base(name, rarity)
        {
            this.MinDmg *= 3;
            this.MaxDmg *= 4;
            this.Sockets = new Gem[2];
        }
    }
}
