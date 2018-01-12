namespace _1.Avatar
{
   public class WaterBender : Bender
    {
        private float waterClarity;
        
        public float WaterClarity
        {
            get { return this.waterClarity; }
            set { this.waterClarity = value; }
        }

        public WaterBender(string name, int power,float waterClarity) : base(name, power)
        {
            this.WaterClarity = waterClarity;
            this.TotalPower = this.Power * this.WaterClarity;
        }
        public override string ToString()
        {
            return $"Water Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.WaterClarity:f2}";
        }
    }
}