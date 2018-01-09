namespace _2.Vehicles_Extension
{
    using System;
    public class Car : Vehicle
    {
        public Car(string type, double fuelQuantity, double fuelConsumption,double tankCapacity) : base(type, fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double Drive(double distanceToTravel)
        {
            if ((base.FuelConsumption + 0.9) * distanceToTravel > base.FuelQuantity)
            {
                throw new ArgumentException("Car needs refueling");
            }
            else
            {
                Console.WriteLine(($"Car travelled {distanceToTravel} km"));
                DistanceTravelled += distanceToTravel;
                return base.FuelQuantity = base.FuelQuantity - (base.FuelConsumption + 0.9) * distanceToTravel;
            }
        }

        public override double DriveEmpty(double distanceToTravel)
        {
            throw new ArgumentException("Car cannot be driven empty");
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