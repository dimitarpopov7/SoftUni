namespace _1.Need_For_Speed
{
    using System;
    using System.Collections.Generic;
    public class CarManager
    {
        public static Dictionary<int, Car> Cars = new Dictionary<int, Car>();
        public static Dictionary<int, Race> Races = new Dictionary<int, Race>();
        public static HashSet<int> RaceParticipants = new HashSet<int>();

        public static void Register(int id, string type, string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
        {
            switch (type)
            {
                case "Performance":
                    var performanceCar = new PerformanceCar(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability);
                    Cars.Add(id, performanceCar);
                    break;
                case "Show":
                    var showCar = new ShowCar(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability);
                    Cars.Add(id, showCar);
                    break;
            }
        }
        public static string Check(int id)
        {
            var carToCheck = Cars[id];
            return carToCheck.ToString();
        }
        public static void Open(int id, string type, int length, string route, int prizePool)
        {
            switch (type)
            {
                case "Casual":
                    var casualRace = new CasualRace(length, route, prizePool);
                    Races.Add(id, casualRace);
                    break;
                case "Drag":
                    var dragRace = new DragRace(length, route, prizePool);
                    Races.Add(id, dragRace);
                    break;
                case "Drift":
                    var driftRace = new DragRace(length, route, prizePool);
                    Races.Add(id, driftRace);
                    break;
            }
        }
        public static void OpenSpecial(int id, string type, int length, string route, int prizePool,int lapsOrGold)
        {
            switch (type)
            {                
                case "Circuit":
                    var circuitRace = new CircuitRace(length, route, prizePool,lapsOrGold);
                    Races.Add(id, circuitRace);
                    break;
                case "TimeLimit":
                    var timeLimitRace = new TimeLimitRace(length, route, prizePool,lapsOrGold);
                    Races.Add(id, timeLimitRace);
                    break;
            }
        }
        public static void Participate(int carId, int raceId)
        {
            if (!Garage.ParkedCars.Contains(carId))
            {
                if(Races[raceId] is TimeLimitRace)
                {
                    if (Races[raceId].Participants.Count != 1)
                    {
                        Races[raceId].Participants.Add(Cars[carId]);
                        RaceParticipants.Add(carId);
                    }
                }
                else
                {
                    Races[raceId].Participants.Add(Cars[carId]);
                    RaceParticipants.Add(carId);
                }                
            }
        }
        public static string Start(int id)
        {
            if (Races[id].Participants.Count < 1)
            {
                return "Cannot start the race with zero participants";
            }
            else
            {
                return Races[id].ToString();
            }            
        }
        public static void Park(int id)
        {
            if (!RaceParticipants.Contains(id))
            {
                Garage.ParkedCars.Add(id);
            }
            else
            {
                throw new ArgumentException("Car is participating in a race and cannot go to the garage now.");
            }
        }
        public static void Unpark(int id)
        {
            if (Garage.ParkedCars.Contains(id))
            {
                Garage.ParkedCars.Remove(id);
                Garage.ParkedCars.Remove(id);
            }
        }
        public static void Tune(int tuneIndex, string addOn)
        {
            foreach (var id in Garage.ParkedCars)
            {
                Cars[id].TuneCar(tuneIndex, addOn);
            }
        }
    }
}