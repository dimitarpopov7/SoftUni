namespace _1.Avatar
{    
    public class EarthMonument : Monuments
    {
        public EarthMonument(string name, int airAffinity) : base(name)
        {
            this.BonusPower = airAffinity;
        }
        public override string ToString()
        {
            return $"Earth{base.ToString()}Earth Affinity: {this.BonusPower}";
        }
    }
}