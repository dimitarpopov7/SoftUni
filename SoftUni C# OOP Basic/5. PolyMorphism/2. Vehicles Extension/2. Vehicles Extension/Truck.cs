namespace _2.Vehicles_Extension
{
    using System;
    public class Truck : Vehicle
    {
        public Truck(string type, double fuelQuantity, double fuelConsumption,double tankCapacity) : base(type, fuelQuantity, fuelConsumption,tankCapacity)
        {            
        }

        public override double Drive(double distanceToTravel)
        {
            if ((base.FuelConsumption + 1.6) * distanceToTravel > base.FuelQuantity)
            {
                throw new ArgumentException("Truck needs refueling");
            }
            else
            {
                DistanceTravelled += distanceToTravel;
                Console.WriteLine(($"Truck travelled {distanceToTravel} km"));
                return base.FuelQuantity = base.FuelQuantity - (base.FuelConsumption + 1.6) * distanceToTravel;
            }
        }

        public override double DriveEmpty(double distanceToTravel)
        {
            throw new ArgumentException("Truck cannot be driven Empty");
        }

        public override double Refuel(double refuelLiters)
        {
            if (base.TankCapacity < base.FuelQuantity + refuelLiters)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            return base.FuelQuantity = base.FuelQuantity + refuelLiters * 95 / 100;
        }
    }
}