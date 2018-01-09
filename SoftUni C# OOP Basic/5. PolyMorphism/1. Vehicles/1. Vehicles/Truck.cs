namespace _1.Vehicles
{
    using System;
    public class Truck : Vehicle
    {     
        public Truck(string type,double fuelQuantity, double fuelConsumption) : base(type,fuelQuantity, fuelConsumption)
        {            
            base.FuelQuantity = fuelQuantity;
            base.FuelConsumption = fuelConsumption;
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
                return base.FuelQuantity=base.FuelQuantity - (base.FuelConsumption + 1.6) * distanceToTravel;
            }
        }

        public override double Refuel( double refuelLiters)
        {
            return base.FuelQuantity=base.FuelQuantity + refuelLiters * 95 / 100;
        }       
    }
}