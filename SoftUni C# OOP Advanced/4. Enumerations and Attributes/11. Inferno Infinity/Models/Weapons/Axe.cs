using System.Linq;

namespace _11.Inferno_Infinity.Models.Weapons
{
    public class Axe : Weapon
    {
        public Axe(string name, string rarity) : base(name, rarity)
        {
            this.Sockets = new Gem[4];
            //this.Strenght = this.Sockets.Sum(gem => gem.Strenght);
            //this.Agility = this.Sockets.Sum(gem => gem.Agility);
            //this.Vitality = this.Sockets.Sum(gem => gem.Vitality);

            this.MinDmg *= 5;// + this.Strenght * 2 + this.Agility * 1;
            this.MaxDmg *= 10;// + this.Strenght * 3 + this.Agility * 4;
            
        }
    }
}
