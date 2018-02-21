namespace _11.Inferno_Infinity.Models.Gems
{
    public class Amethyst : Gem
    {
        public Amethyst(string clarity) : base(clarity)
        {
            this.Strenght += 2;
            this.Agility += 8;
            this.Vitality += 4;
        }
    }
}