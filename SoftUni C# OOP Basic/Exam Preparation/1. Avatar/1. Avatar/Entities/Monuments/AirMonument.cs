namespace _1.Avatar
{    
    public class AirMonument : Monuments
    {
        public AirMonument(string name,int airAffinity) : base(name)
        {
            this.BonusPower = airAffinity;
        }
        public override string ToString()
        {
            return $"Air{base.ToString()}Air Affinity: {this.BonusPower}";
        }
    }
}