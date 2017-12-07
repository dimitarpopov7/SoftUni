namespace _4.Champions_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new List<Team>();
            while (input != "stop")
            {
                var matchInfo = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var teamA = matchInfo[0];
                var teamB = matchInfo[1];

                var aTeam = new Team() { Name = teamA };
                var bTeam = new Team() { Name = teamB };

                var firstScore = matchInfo[2].Split(':').Select(int.Parse).ToList();
                var secondScore = matchInfo[3].Split(':').Select(int.Parse).ToList();
                bool teamAWins = false;
                if (firstScore[0] + secondScore[1] > firstScore[1] + secondScore[0])
                {
                    teamAWins = true;
                }
                else if (firstScore[0] + secondScore[1] == firstScore[1] + secondScore[0])
                {
                    if (firstScore[1] < secondScore[1])
                    {
                        teamAWins = true;
                    }
                }
                var winner = string.Empty;
                var loser = string.Empty;
                switch (teamAWins)
                {
                    case true:
                        winner = teamA;
                        loser = teamB;
                        break;
                    case false:
                        winner = teamB;
                        loser = teamA;
                        break;
                }
                UpdateTeams(result, winner, loser, 1);
                UpdateTeams(result, loser, winner, 0);
                input = Console.ReadLine();
            }
            foreach (var team in result.OrderByDescending(x=>x.Wins).ThenBy(x=>x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- Wins: {team.Wins}");
                Console.WriteLine($"- Opponents: {string.Join(", ",team.Opponents.OrderBy(x=>x))}");
            }
        }
        private static void UpdateTeams(List<Team> result, string aTeam, string bTeam, int wins)
        {
            var currentTeam = result.Where(x => x.Name == aTeam).FirstOrDefault();
            if (currentTeam == null)
            {
                result.Add(new Team
                {
                    Name = aTeam,
                    Wins = wins,
                    Opponents = new HashSet<string>() { bTeam }
                });
            }
            else
            {
                currentTeam.Wins += wins;
                currentTeam.Opponents.Add(bTeam);
            }            
        }
    }
}