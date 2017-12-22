namespace _7.Car_Salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int numEngines = int.Parse(Console.ReadLine());
            var engineList = new List<Engine>();
            var carList = new List<Car>();
            for (int i = 0; i < numEngines; i++)
            {
                var engineInfo = Console.ReadLine().Split().ToList();
                var model = engineInfo[0];
                var power = int.Parse(engineInfo[1]);
                string displacement = "n/a";
                string efficiency = "n/a";
                if (engineInfo.Count > 2)
                {
                    int n;
                    var displacementOrEfficiency = int.TryParse(engineInfo[2], out n);
                    if (displacementOrEfficiency)
                    {
                        displacement = engineInfo[2];
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                    }
                }
                if (engineInfo.Count > 3)
                {
                    displacement = engineInfo[2];
                    efficiency = engineInfo[3];
                }
                var currentEngine = new Engine(model, power, displacement, efficiency);
                engineList.Add(currentEngine);
            }
            var m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var carInfo = Console.ReadLine().Split().ToList();
                var model = carInfo[0];
                var engineName = carInfo[1];
                string weight = "n/a";
                string color = "n/a";
                if (carInfo.Count > 2)
                {
                    int n;
                    var weightOrColor = int.TryParse(carInfo[2], out n);
                    if (weightOrColor)
                    {
                        weight = carInfo[2];
                    }
                    else
                    {
                        color =carInfo[2];
                    }
                }
                if (carInfo.Count > 3)
                {
                    weight = carInfo[2];
                    color = carInfo[3];
                }
                Engine engine = engineList.Where(x => x.Model == engineName).FirstOrDefault();
                var currentCar = new Car(model,engine,color,weight);
                carList.Add(currentCar);
            }
            foreach (var car in carList)
            {                
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"    {car.Engine.Model}:");
                Console.WriteLine($"        Power: {car.Engine.Power}");
                Console.WriteLine($"        Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"        Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"    Weight: {car.Weight}");
                Console.WriteLine($"    Color: {car.Color}");
            }
        }
    }
}