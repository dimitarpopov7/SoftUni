namespace _1.Avatar
{
    public class FireBender : Bender
    {
        private float heatAggression;
        
        public float HeatAggression
        {
            get { return this.heatAggression; }
            set { this.heatAggression = value; }
        }

        public FireBender(string name, int power,float heatAggression) : base(name, power)
        {
            this.HeatAggression = heatAggression;
            this.TotalPower = this.Power * HeatAggression;
        }
        public override string ToString()
        {
            return $"Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAggression:f2}";
        }
    }
}