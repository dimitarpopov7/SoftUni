
namespace _3.Car
{
    public class Car
    {
        private decimal speed;
        private decimal fuel;
        private int fuelEfficiency;
        private decimal distance;
        
        public decimal Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }        
        public decimal Speed => this.speed;        
        public int FuelEfficiency => this.fuelEfficiency;
        public decimal Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }        
        public Car(int speed,int fuel, int fuelEfficiency)
        {
            this.speed = speed;
            this.fuel = fuel;
            this.fuelEfficiency = fuelEfficiency;
        }        
    }
}
