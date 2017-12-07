namespace _4.Champions_League
{
    using System.Collections.Generic;
    public class Team
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public HashSet<string> Opponents { get; set; }
    }
}