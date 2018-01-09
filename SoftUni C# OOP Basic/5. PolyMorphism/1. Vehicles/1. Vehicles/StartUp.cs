namespace _1.Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    
    public class StartUp
    {
        public static void Main()
        {
            var info1 = Console.ReadLine().Split().ToList();
            var info2 = Console.ReadLine().Split().ToList();
            var entries = int.Parse(Console.ReadLine());
            var vehicle1 = VehicleFactory.CreateVehicle(info1[0], double.Parse(info1[1]), double.Parse(info1[2]));
            var vehicle2 = VehicleFactory.CreateVehicle(info2[0], double.Parse(info2[1]), double.Parse(info2[2]));
            List<Vehicle> vehicleList = new List<Vehicle>();
            vehicleList.Add(vehicle1);
            vehicleList.Add(vehicle2);
            for (int i = 0; i < entries; i++)
            {
                var command = Console.ReadLine().Split().ToList();
                var action = command[0];
                var vehicleType = command[1];
                var litersOrKm = double.Parse(command[2]);
                var currentVehicle = vehicleList.FirstOrDefault(x => x.type == vehicleType);
                vehicleList.Remove(currentVehicle);
                try
                {                    
                    if (action == "Drive")
                    {
                        currentVehicle.Drive(litersOrKm);
                    }
                    else if (action == "Refuel")
                    {
                        currentVehicle.Refuel(litersOrKm);
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                vehicleList.Add(currentVehicle);
            }
            foreach (var vehicle in vehicleList.OrderBy(x=>x.type))
            {
                Console.WriteLine(vehicle.Info());                
            }
        }
    }
}