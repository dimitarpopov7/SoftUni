namespace _1.Avatar
{
    public class FireMonument : Monuments
    {
        public FireMonument(string name, int airAffinity) : base(name)
        {
            this.BonusPower = airAffinity;
        }
        public override string ToString()
        {
            return $"Fire{base.ToString()}Fire Affinity: {this.BonusPower}";
        }
    }
}