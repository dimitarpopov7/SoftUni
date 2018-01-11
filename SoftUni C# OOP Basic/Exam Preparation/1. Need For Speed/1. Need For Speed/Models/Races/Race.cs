namespace _1.Need_For_Speed
{
    using System.Collections.Generic;
    public abstract class Race
    {        
        private int lenght;
        private string route;
        private int prizePool;
        private HashSet<Car> participants;
        public Dictionary<int, int> PrizeMoney;
        public Dictionary<int, int> PrizeMoneyCirc;
        public Dictionary<int, int> PrizeMoneyTime;

        public Race(int lenght, string route, int prizePool,Dictionary<int,int> prizeMoney=null, HashSet<Car> participants=null)
        {
            this.Lenght = lenght;
            this.Route = route;
            this.PrizePool = prizePool;
            this.Participants = new HashSet<Car>();
            this.PrizeMoney = new Dictionary<int, int>() { { 1, this.prizePool * 50 / 100 }, { 2, this.prizePool * 30 / 100 }, { 3, this.prizePool * 20 / 100 } };
            this.PrizeMoneyCirc=new Dictionary<int, int>() { { 1, this.prizePool * 40 / 100 }, { 2, this.prizePool * 30 / 100 }, { 3, this.prizePool * 20 / 100 }, { 4,this.prizePool*10/100} };
            this.PrizeMoneyTime = new Dictionary<int, int>() { { 1, this.prizePool * 40 / 100 }, { 2, this.prizePool * 50 / 100 }, { 3, this.prizePool * 30 / 100 } };
        }

        public abstract override string ToString();

        //properties ready for future verifications..

        public HashSet<Car> Participants
        {
            get { return this.participants; }
            set { this.participants = value; }
        }

        public int PrizePool
        {
            get { return this.prizePool; }
            set { this.prizePool = value; }
        }

        public string Route
        {
            get { return this.route; }
            set { this.route = value; }
        }

        public int Lenght
        {
            get { return this.lenght; }
            set { this.lenght = value; }
        }
    }
}