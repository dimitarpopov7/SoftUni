namespace _2.Vehicles_Extension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            //could improve it in case we get more entries...
            var info1 = Console.ReadLine().Split().ToList();
            var info2 = Console.ReadLine().Split().ToList();
            var info3 = Console.ReadLine().Split().ToList();
            var entries = int.Parse(Console.ReadLine());
            var vehicle1 = VehicleFactory.CreateVehicle(info1[0], double.Parse(info1[1]), double.Parse(info1[2]), double.Parse(info1[3]));
            var vehicle2 = VehicleFactory.CreateVehicle(info2[0], double.Parse(info2[1]), double.Parse(info2[2]), double.Parse(info2[3]));
            var vehicle3 = VehicleFactory.CreateVehicle(info3[0], double.Parse(info3[1]), double.Parse(info3[2]), double.Parse(info3[3]));
            List<Vehicle> vehicleList = new List<Vehicle>();
            vehicleList.Add(vehicle1);
            vehicleList.Add(vehicle2);
            vehicleList.Add(vehicle3);
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
                    else if (action == "DriveEmpty")
                    {
                        currentVehicle.DriveEmpty(litersOrKm);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                vehicleList.Add(currentVehicle);
            }
            Print(vehicleList);
        }
        public static void Print(List<Vehicle> listVehicles)
        {
            var queVehicles = new Queue<Vehicle>();
            queVehicles.Enqueue(listVehicles.FirstOrDefault(x => x.type == "Car"));
            queVehicles.Enqueue(listVehicles.FirstOrDefault(x => x.type == "Truck"));
            queVehicles.Enqueue(listVehicles.FirstOrDefault(x => x.type == "Bus"));
            foreach (var vehicle in queVehicles)
            {
                Console.WriteLine(vehicle.Info());
            }
        }
    }
}