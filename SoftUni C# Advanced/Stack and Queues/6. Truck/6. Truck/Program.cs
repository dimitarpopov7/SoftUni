namespace _6.Truck
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var gasPumps = new Queue<GasPumpInfo>();
            for (int i = 0; i < n; i++)
            {
                var lineInfo = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
                var currentPump = new GasPumpInfo();
                currentPump.FuelAdded = lineInfo[0];
                currentPump.DistanceToNextStation = lineInfo[1];
                currentPump.GasPumpIndex = i;
                gasPumps.Enqueue(currentPump);
            }
            var startStation = new GasPumpInfo();
            int totalFuelLeft = 0;            
            while (true)
            {
                //take first station and add it at the back
                var currentStation = gasPumps.Dequeue();
                gasPumps.Enqueue(currentStation);
                //get how much fuel we have
                totalFuelLeft += currentStation.FuelAdded - currentStation.DistanceToNextStation;
                //check if we have fuel
                if (totalFuelLeft >= 0)
                {
                    startStation = currentStation;
                    while (true)
                    {
                        //station 2 becomes our first one and we leave start station at the back of the queue
                        currentStation = gasPumps.Dequeue();
                        gasPumps.Enqueue(currentStation);
                        totalFuelLeft += currentStation.FuelAdded - currentStation.DistanceToNextStation;
                        if (totalFuelLeft >= 0)
                        {
                            if (startStation == currentStation)
                            {
                                Console.WriteLine(startStation.GasPumpIndex);
                                return;
                            }
                            continue;
                        }
                        else
                        {
                            totalFuelLeft = 0;
                            break;
                        }
                    }
                }
                else
                {
                    totalFuelLeft = 0;
                }
            }
        }
    }
}
