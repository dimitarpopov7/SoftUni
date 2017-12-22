namespace _5.Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        public static void Main()
        {
            int numOfCars = int.Parse(Console.ReadLine());
            var listOfCars = new List<Car>();
            for (int i = 0; i < numOfCars; i++)
            {
                var entry = Console.ReadLine().Split().ToList();
                var currentCar = new Car(entry[0], double.Parse(entry[1]), double.Parse(entry[2]));
                listOfCars.Add(currentCar);
            }
            var drive = Console.ReadLine().Split().ToList();
            while (drive[0]!="End")
            {
                var model = drive[1];
                var distance = int.Parse(drive[2]);
                foreach (var car in listOfCars.Where(x=>x.Model==model))
                {
                    double expense = distance * car.CostPerKm;
                    if (expense > car.Fuel)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                    else
                    {
                        car.Fuel -= expense;
                        car.DistanceTraveled += distance;
                    }
                }
                drive = Console.ReadLine().Split().ToList();
            }
            foreach (var car in listOfCars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.DistanceTraveled}");
            }      
        }
    }
}