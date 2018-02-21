namespace _11.Inferno_Infinity.Models.Gems
{
    public class Ruby : Gem
    {
        public Ruby(string clarity) : base(clarity)
        {
            this.Strenght += 7;
            this.Agility += 2;
            this.Vitality += 5;
        }
    }
}
