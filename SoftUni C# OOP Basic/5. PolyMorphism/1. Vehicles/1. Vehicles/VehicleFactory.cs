namespace _1.Vehicles
{
    using System;
    public abstract class VehicleFactory
    {
        public static Vehicle CreateVehicle(string type,double fuel, double fuelPerKm)
        {
            switch (type)
            {
                case "Car":
                    return new Car(type,fuel, fuelPerKm);
                case "Truck":
                    return new Truck(type,fuel, fuelPerKm);
                default:
                    throw new ArgumentException("Invalid entry");
            }
        }
    }
}