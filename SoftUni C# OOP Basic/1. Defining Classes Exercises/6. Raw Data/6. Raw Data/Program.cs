namespace _6.Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var carsList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split().ToList();

                var model = entry[0];

                var engineSpeed = int.Parse(entry[1]);
                var enginePower = int.Parse(entry[2]);

                var cargoWeight = int.Parse(entry[3]);
                var cargoType = entry[4];

                var tyre1Pressure = double.Parse(entry[5]);
                var tyre1Age = int.Parse(entry[6]);

                var tyre2Pressure = double.Parse(entry[7]);
                var tyre2Age = int.Parse(entry[8]);

                var tyre3Pressure = double.Parse(entry[9]);
                var tyre3Age = int.Parse(entry[10]);

                var tyre4Pressure = double.Parse(entry[11]);
                var tyre4Age = int.Parse(entry[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);

                var tyre1 = new Tyre(tyre1Pressure, tyre1Age);
                var tyre2 = new Tyre(tyre2Pressure, tyre2Age);
                var tyre3 = new Tyre(tyre3Pressure, tyre3Age);
                var tyre4 = new Tyre(tyre4Pressure, tyre4Age);

                var tyres = new List<Tyre>() { tyre1, tyre2, tyre3, tyre4 };
                var currentCar = new Car(model, engine, tyres, cargo);
                carsList.Add(currentCar);
            }
            var cargoTypeToCheck = Console.ReadLine();
            Console.WriteLine(string.Join(Environment.NewLine, carsList
                .Where(c => c.Cargo.Type == cargoTypeToCheck && cargoTypeToCheck == "fragile"
                ? c.Tyres
                .Where(t => t.Pressure < 1)
                .FirstOrDefault() != null
                : c.Engine.Power > 250)
                .Select(c => c.Model)));
        }
    }
}