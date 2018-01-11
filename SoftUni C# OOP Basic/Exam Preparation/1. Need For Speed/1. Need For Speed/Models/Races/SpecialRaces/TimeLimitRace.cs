namespace _1.Need_For_Speed
{    
    using System.Collections.Generic;
    using System.Text;
    public class TimeLimitRace : Race
    {
        public int GoldTime { get; set; }
        public int TimePerormance=0;

        public TimeLimitRace(int lenght, string route, int prizePool,int goldTime, Dictionary<int, int> prizeMoney = null, HashSet<Car> participants = null) : base(lenght, route, prizePool, prizeMoney, participants)
        {
            this.GoldTime = goldTime;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Lenght}");
            foreach (var car in Participants)
            {                
                this.TimePerormance = this.Lenght * ((car.HorsePower / 100) * car.Acceleration);
                sb.AppendLine($"{car.Brand} {car.Model} {this.TimePerormance} s.");
                if (this.TimePerormance <= this.GoldTime)
                {
                    sb.AppendLine($"Gold Time, ${this.PrizeMoneyTime[1]}.");
                }
                else if (this.TimePerormance <= this.GoldTime + 15)
                {
                    sb.AppendLine($"Silver Time, ${this.PrizeMoneyTime[2]}.");
                }
                else if (this.TimePerormance > this.GoldTime + 15)
                {
                    sb.AppendLine($"Bronze Time, ${this.PrizeMoneyTime[3]}.");
                }
            }
            return sb.ToString();
        }
    }
}