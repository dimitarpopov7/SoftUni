namespace _9.Traffic_Lights
{
    using System;
    using Model;
    using Enums;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            List<TrafficLight> trafficLightList = SetTrafficLights();
            PrintLights(trafficLightList);
        }

        private static void PrintLights(List<TrafficLight> trafficLightList)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                foreach (var trafficLight in trafficLightList)
                {
                    trafficLight.ChangeLight();
                }
                Console.WriteLine(string.Join(" ", trafficLightList));
            }
        }

        private static List<TrafficLight> SetTrafficLights()
        {
            var currentSignalOfEachTrafficLight = Console.ReadLine().Split();
            var trafficLightList = new List<TrafficLight>();
            for (int i = 0; i < currentSignalOfEachTrafficLight.Length; i++)
            {
                var currentTrafficLight = new TrafficLight((Signals)Enum.Parse(typeof(Signals), currentSignalOfEachTrafficLight[i]));
                trafficLightList.Add(currentTrafficLight);
            }
            return trafficLightList;
        }
    }
}
