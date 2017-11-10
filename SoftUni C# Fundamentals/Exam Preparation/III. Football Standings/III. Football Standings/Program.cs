namespace III.Football_Standings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            string separator = Console.ReadLine();
            string changeSeparator = "DP7";//DimitarPopov7 the separator characters are special and need escape e.g. '/','?' etc.
            string entry = Console.ReadLine();
            entry=entry.Replace($"{separator}", $"{changeSeparator}");
            string goalsExtract = @"(\d)+;(\d)";
            var regex1 = new Regex($@"{changeSeparator}([A-Za-z]+){changeSeparator}.+{changeSeparator}([A-Za-z]+){changeSeparator}.+(\d+):(\d+)");
            var regex2 = new Regex($@"{goalsExtract}");
            var teamRecord = new Dictionary<string, Team>();
            while (entry != "final")
            {
                var matchInfo = regex1.Matches(entry);
                var currentTeamA = new Team();
                var currentTeamB = new Team();
                foreach (Match line in matchInfo)
                {
                    var teamNameA = line.Groups[1].ToString().ToUpper();
                    var teamArrayA = teamNameA.ToCharArray();
                    Array.Reverse(teamArrayA);
                    teamNameA = new string(teamArrayA);
                    var teamNameB = line.Groups[2].ToString().ToUpper();
                    var teamArrayB = teamNameB.ToCharArray();
                    Array.Reverse(teamArrayB);
                    teamNameB = new string(teamArrayB);
                    int scoreA = int.Parse(line.Groups[3].ToString());
                    int scoreB = int.Parse(line.Groups[4].ToString());
                    int pointsWonA = 0;
                    int pointsWonB = 0;
                    if (scoreA > scoreB)
                    {
                        pointsWonA = 3;
                        pointsWonB = 0;
                    }
                    else if (scoreB > scoreA)
                    {
                        pointsWonB = 3;
                        pointsWonA = 0;
                    }
                    else if (scoreA == scoreB)
                    {
                        pointsWonA = 1;
                        pointsWonB = 1;
                    }
                    if (!teamRecord.ContainsKey(teamNameA))
                    {
                        currentTeamA.GoalsScored = scoreA;
                        currentTeamA.points = pointsWonA;
                        teamRecord[teamNameA]=currentTeamA;
                    }
                    else
                    {
                        currentTeamA.GoalsScored = scoreA+teamRecord[teamNameA].GoalsScored;
                        currentTeamA.points = pointsWonA+teamRecord[teamNameA].points;
                        teamRecord[teamNameA] = currentTeamA;
                    }
                    if (!teamRecord.ContainsKey(teamNameB))
                    {
                        currentTeamB.GoalsScored = scoreB;
                        currentTeamB.points = pointsWonB;
                        teamRecord[teamNameB]=currentTeamB;
                    }
                    else
                    {
                        currentTeamB.GoalsScored += scoreB;
                        currentTeamB.points += pointsWonB;
                        currentTeamB.GoalsScored = scoreB + teamRecord[teamNameB].GoalsScored;
                        currentTeamB.points = pointsWonB + teamRecord[teamNameB].points;
                        teamRecord[teamNameB] = currentTeamB;
                    }
                }
                entry = Console.ReadLine();
                entry = entry.Replace($"{separator}", $"{changeSeparator}");
            }
            Console.WriteLine("League standings:");
            int place = 1;
            foreach (var team in teamRecord.OrderByDescending(x=>x.Value.points).ThenBy(x=>x.Key))
            {                
                Console.WriteLine($"{place}. {team.Key} {team.Value.points}");
                place += 1;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teamRecord.OrderByDescending(x=>x.Value.GoalsScored).ThenBy(x=>x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.GoalsScored}");                
            }
        }
    }
}
