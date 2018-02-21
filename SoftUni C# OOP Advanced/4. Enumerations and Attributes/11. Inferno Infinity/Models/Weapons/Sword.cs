namespace _11.Inferno_Infinity.Models.Weapons
{
    public class Sword : Weapon
    {
        public Sword(string name, string rarity) : base(name, rarity)
        {
            this.MinDmg *= 4;
            this.MaxDmg *= 6;
            this.Sockets = new Gem[3];
        }
    }
}
