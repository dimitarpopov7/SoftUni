namespace _7.Car_Salesman
{
    public class Engine
    {
        private string model;
        private int power;
        private string displacements;
        private string efficiency;
        public Engine(string model,int power)
        {
            this.model = model;
            this.power = power;
            this.displacements = "n/a";
            this.efficiency = "n/a";
        }
        public Engine(string model, int power, string displacements)
            :this (model,power)
        {
            this.displacements = displacements;
        }
        public Engine(string model,string efficiency,int power)
            : this(model, power)
        {
            this.efficiency = efficiency;
        }
        public Engine(string model,int power,string displacements,string efficiency)
            :this(model, power)
        {
            this.displacements = displacements;
            this.efficiency = efficiency;
        }
        public string Model
        {
            get { return this.model; }
        }
        public int Power
        {
            get { return this.power; }
        }
        public string Displacement
        {
            get { return this.displacements; }
        }
        public string Efficiency
        {
            get { return this.efficiency; }
        }
    }
}