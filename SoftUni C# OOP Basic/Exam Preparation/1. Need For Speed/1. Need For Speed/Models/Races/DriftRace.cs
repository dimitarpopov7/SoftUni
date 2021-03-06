﻿namespace _1.Need_For_Speed
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DriftRace : Race
    {
        public DriftRace(int lenght, string route, int prizePool, Dictionary<int, int> prizeMoney=null, HashSet<Car> participants = null) : base(lenght, route, prizePool, prizeMoney, participants)
        {
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Lenght}");
            int position = 1;
            foreach (var car in Participants.OrderByDescending(x => (x.Suspension + x.Durability)).Take(3))
            {
                sb.AppendLine($"{position}. {car.Brand} {car.Model} {(car.HorsePower / car.Acceleration) + (car.Suspension + car.Durability)}PP - ${this.PrizeMoney[position]}");
                position++;
            }
            return sb.ToString();
        }
    }
}