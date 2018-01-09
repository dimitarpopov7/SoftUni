namespace _2.Vehicles_Extension
{
    using System;
    using System.Text;
    public abstract class Vehicle
    {
        public string type { get; set; }
        private double fuelQuantity;        
        private double fuelConsumption;
        private double tankCapacity;

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            set
            {
                this.tankCapacity = value;
            }
        }
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuelQuantity = value;
            }
        }
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set
            {
                this.fuelConsumption = value;
            }
        }
        public double DistanceTravelled = 0;
        public Vehicle(string type, double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.type = type;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }
        public abstract double Drive(double distanceToTravel);
        public abstract double Refuel(double refuelLiters);
        public abstract double DriveEmpty(double distanceToTravel);
        public string Info()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.type}: {this.FuelQuantity:f2}");
            return sb.ToString();
        }
    }
}