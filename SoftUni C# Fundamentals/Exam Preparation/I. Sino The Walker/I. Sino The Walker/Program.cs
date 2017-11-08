namespace I.Sino_The_Walker
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string time = Console.ReadLine();
            DateTime startTime = DateTime.Parse(time);
            int steps = int.Parse(Console.ReadLine()) % 86400;//if we walk more than a day
            int secPerStep = int.Parse(Console.ReadLine()) % 86400;//if we walk more than a day
            int totalSecWalking = (steps * secPerStep);
            var endTime=startTime.AddSeconds(totalSecWalking);
            string result = endTime.ToString("HH:mm:ss");
            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}
