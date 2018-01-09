namespace _1.Vehicles
{
    using System;
    public class Car : Vehicle
    {        
        public Car(string type,double fuelQuantity, double fuelConsumption) : base(type,fuelQuantity, fuelConsumption)
        {            
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
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
                return base.FuelQuantity=base.FuelQuantity - (base.FuelConsumption + 0.9) * distanceToTravel;
            }
        }
        public override double Refuel(double refuelLiters)
        {
            return base.FuelQuantity=base.FuelQuantity + refuelLiters;
        }        
    }
}