namespace _1.Avatar
{    
    public abstract class Bender
    {
        private string name;
        private int power;
        public virtual double TotalPower { get; set; }

        public Bender(string name, int power)
        {            
            this.Name = name;
            this.Power = power;
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}