namespace _5.Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuel;
        private double costPerKm;
        private int distanceTraveled;
        public Car(string model,double fuel,double costPerKm)
        {
            this.model = model;
            this.fuel = fuel;
            this.costPerKm = costPerKm;
            this.distanceTraveled = 0;
        }
        public string Model
        {
            get { return this.model; }
        }
        public double Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }
        public double CostPerKm
        {
            get { return this.costPerKm; }
        }
        public int DistanceTraveled
        {
            get { return this.distanceTraveled; }
            set { this.distanceTraveled = value; }
        }
    }
}