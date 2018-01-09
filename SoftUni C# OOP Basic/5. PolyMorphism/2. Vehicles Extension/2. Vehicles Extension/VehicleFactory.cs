namespace _2.Vehicles_Extension
{
    using System;
    public abstract class VehicleFactory
    {
        public static Vehicle CreateVehicle(string type, double fuel, double fuelPerKm,double tankCapacity)
        {
            switch (type)
            {
                case "Car":
                    return new Car(type, fuel, fuelPerKm,tankCapacity);
                case "Truck":
                    return new Truck(type, fuel, fuelPerKm,tankCapacity);
                case "Bus":
                    return new Bus(type, fuel, fuelPerKm, tankCapacity);
                default:
                    throw new ArgumentException("Invalid entry");
            }
        }
    }
}
