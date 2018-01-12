namespace _1.Avatar
{    
    public class WaterMonument : Monuments
    {
        public WaterMonument(string name, int airAffinity) : base(name)
        {
            this.BonusPower = airAffinity;
        }
        public override string ToString()
        {
            return $"Water{base.ToString()}Water Affinity: {this.BonusPower}";
        }
    }
}