namespace _1.Avatar
{
    public class EarthBender : Bender
    {
        private float groundSaturation;
        
        public float GroudSaturation
        {
            get { return this.groundSaturation; }
            set { this.groundSaturation = value; }
        }

        public EarthBender(string name, int power,float grounSaturation) : base(name, power)
        {
            this.GroudSaturation = grounSaturation;
            this.TotalPower = this.Power * this.GroudSaturation;
        }
        public override string ToString()
        {
            return $"Earth Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.GroudSaturation:f2}";
        }

        
    }
}