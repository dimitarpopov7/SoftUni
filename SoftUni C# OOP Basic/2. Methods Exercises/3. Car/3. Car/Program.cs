namespace _3.Car
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var information = Console.ReadLine().Split().Select(int.Parse).ToList();
            var car = new Car(information[0], information[1], information[2]);
            var command = Console.ReadLine();
            decimal kmPerLiter = car.FuelEfficiency / car.Speed;
            while(command!="END")
            {
                if (command.Contains("Travel"))
                {
                    var travel = command.Split().ToList();
                    if (car.Fuel >= kmPerLiter * int.Parse(travel[1]))
                    {
                        car.Fuel -= kmPerLiter*int.Parse(travel[1]);
                        car.Distance += decimal.Parse(travel[1]);
                    }
                    else
                    {
                        car.Fuel = 0;
                        car.Distance += car.Fuel / kmPerLiter;
                    }
                }
                else if (command.Contains("Refuel"))
                {
                    var refuel = command.Split().ToList();
                    car.Fuel += command[1];
                    Console.WriteLine($"Total Fuel: {car.Fuel}");
                }
                else if (command == "Distance")
                {
                    Console.WriteLine($"Total distance traveled: {car.Distance:f1} kilometers");
                }
                else if (command == "Time")
                {
                    TimeSpan span = TimeSpan.FromMinutes((double)car.Distance / (double)car.Speed * 60);
                    string label = span.ToString(@"hh\:mm");
                    Console.WriteLine($"Total time: {label}");
                }
                else if (command == "Fuel")
                {
                    Console.WriteLine($"Fuel left: {car.Fuel:f2}");
                }
                command = Console.ReadLine();
            }
        }
    }
}