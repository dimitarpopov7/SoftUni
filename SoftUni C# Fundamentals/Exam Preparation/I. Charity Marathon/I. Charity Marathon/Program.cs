namespace I.Charity_Marathon
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int numRunners = int.Parse(Console.ReadLine());
            int averageNumLaps = int.Parse(Console.ReadLine());
            int trackLenght = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyDonatedPerKm = double.Parse(Console.ReadLine());
            int capacityForAllDays = trackCapacity * days;
            int allowedParticipants = Math.Min(capacityForAllDays, numRunners);
            long totalKmrRan = (long)allowedParticipants * trackLenght * averageNumLaps / 1000;
            double totalMoney = totalKmrRan*moneyDonatedPerKm;
            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
