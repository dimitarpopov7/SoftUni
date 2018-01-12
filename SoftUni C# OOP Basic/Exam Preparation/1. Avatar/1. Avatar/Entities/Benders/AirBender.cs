namespace _1.Avatar
{    
    public class AirBender : Bender
    {
        private float aerialIntegrity;
        
        public float AerialIntegrity 
        {
            get { return this.aerialIntegrity; }
            set { this.aerialIntegrity = value; }
        }

        public AirBender(string name, int power,float aerialIntegrity) : base(name, power)
        {
            this.AerialIntegrity = aerialIntegrity;
            this.TotalPower = this.Power * this.AerialIntegrity;
        }
        public override string ToString()
        {
            return $"Air Bender: {this.Name}, Power: {this.Power}, Aerial Integrity: {this.AerialIntegrity:f2}";
        }
    }
}