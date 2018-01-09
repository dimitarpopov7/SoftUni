namespace _1.Vehicles
{
    using System.Text;
    public abstract class Vehicle
    {
        public string type { get; set; }
        private double fuelQuantity;
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set
            {
                this.fuelQuantity = value;
            }
        }
        private double fuelConsumption;
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set
            {
                this.fuelConsumption = value;
            }
        }
        public double DistanceTravelled = 0;
        public Vehicle( string type,double fuelQuantity, double fuelConsumption)
        {
            this.type = type;
            this.fuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public abstract double Drive(double distanceToTravel);
        public abstract double Refuel(double refuelLiters);
        public string Info()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.type}: {this.FuelQuantity:f2}");
            return sb.ToString();
        }
    }
}
