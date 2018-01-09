namespace _2.Vehicles_Extension
{
    using System;
    public class Bus : Vehicle
    {
        public Bus(string type, double fuelQuantity, double fuelConsumption, double tankCapacity) : base(type, fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double Drive(double distanceToTravel)
        {
            if ((base.FuelConsumption + 1.4) * distanceToTravel > base.FuelQuantity)
            {
                throw new ArgumentException("Bus needs refueling");
            }
            else
            {
                Console.WriteLine(($"Bus travelled {distanceToTravel} km"));
                DistanceTravelled += distanceToTravel;
                return base.FuelQuantity = base.FuelQuantity - (base.FuelConsumption + 1.4) * distanceToTravel;
            }
        }
        public override double DriveEmpty(double distanceToTravel)
        {
            if (base.FuelConsumption * distanceToTravel > base.FuelQuantity)
            {
                throw new ArgumentException("Bus needs refueling");
            }
            else
            {
                Console.WriteLine(($"Bus travelled {distanceToTravel} km"));
                DistanceTravelled += distanceToTravel;
                return base.FuelQuantity = base.FuelQuantity - (base.FuelConsumption + 1.4) * distanceToTravel;
            }
        }

        public override double Refuel(double refuelLiters)
        {
            if (base.TankCapacity < base.FuelQuantity + refuelLiters)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            return base.FuelQuantity = base.FuelQuantity + refuelLiters;
        }
    }
}