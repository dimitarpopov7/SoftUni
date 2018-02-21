namespace _11.Inferno_Infinity.Models.Gems
{
    public class Emerald : Gem
    {
        public Emerald(string clarity) : base(clarity)
        {
            this.Strenght +=1;
            this.Agility += 4;
            this.Vitality += 9;
        }
    }
}