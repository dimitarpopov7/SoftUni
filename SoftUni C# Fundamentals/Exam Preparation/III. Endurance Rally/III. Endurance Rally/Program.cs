namespace III.Endurance_Rally
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var diversList = Console.ReadLine().Split(' ').ToList();
            var zones = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToList();
            var checkPoint = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToList();
            int zoneReached = 0;
            foreach (var competitor in diversList)
            {
                double startFuel = (double)competitor[0];
                for (int i = 0; i < zones.Count; i++)
                {
                    if (checkPoint.Contains(i))
                    {
                        startFuel+=zones[i];
                        if (startFuel <= 0)
                        {
                            zoneReached = i;
                            break;                            
                        }
                    }
                    else
                    {
                        startFuel = startFuel - zones[i];
                        if (startFuel <= 0)
                        {
                            zoneReached = i;
                            break;
                        }
                    }                    
                }
                if (startFuel <= 0)
                {
                    Console.WriteLine($"{competitor} - reached {zoneReached}");
                }
                else
                {
                    Console.WriteLine($"{competitor} - fuel left {startFuel:f2}");
                }
            }
        }
    }
}
