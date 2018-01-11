namespace _1.Need_For_Speed
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class CircuitRace : Race
    {       
        public int Laps { get; set; }
        public CircuitRace(int lenght, string route, int prizePool, int laps,Dictionary<int, int> prizeMoney = null, HashSet<Car> participants = null) : base(lenght, route, prizePool, prizeMoney, participants)
        {            
            this.Laps = laps;            
        }

        public override string ToString()
        {            
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Lenght*this.Laps}");
            int position = 1;
            foreach (var participant in Participants)
            {
                participant.Durability -= this.Laps * (this.Lenght * this.Lenght);
            }
            foreach (var car in Participants.OrderByDescending(x => ((x.HorsePower / x.Acceleration) + (x.Suspension + x.Durability))).Take(4))
            {
                sb.AppendLine($"{position}. {car.Brand} {car.Model} {(car.HorsePower / car.Acceleration) + (car.Suspension + car.Durability)}PP - ${this.PrizeMoneyCirc[position]}");
                position++;                
            }
            return sb.ToString();
        }
    }
}