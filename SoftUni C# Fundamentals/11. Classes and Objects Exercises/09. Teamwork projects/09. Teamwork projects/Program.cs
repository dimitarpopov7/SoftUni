namespace _09.Teamwork_projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;   
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var teams = new List<Teams>();
            string creator = null;
            string team = null;
            var finalAddList = new List<Teams>();
            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split('-').ToList();
                creator = entry[0];
                team = entry[1];
                if (teams.Select(x=>x.TeamName)!= null)
                {
                    if (!teams.Select(x=>x.TeamName).Contains(team))
                    {
                        if (teams.Select(x => x.Creator).Contains(creator))
                        {
                            Console.WriteLine($"{creator} cannot create another team!");
                        }
                        else
                        {
                            var currentTeam = new Teams();
                            var currentTeamAddList = new List<string>();
                            currentTeam.TeamName = team;
                            currentTeam.Creator = creator;
                            currentTeamAddList.Add(creator);
                            currentTeam.TeamMembers = currentTeamAddList;
                            Console.WriteLine($"Team {team} has been created by {creator}!");
                            finalAddList.Add(currentTeam);
                            teams = finalAddList;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Team {team} was already created!");
                    }
                }
                else
                {
                    var currentTeam = new List<Teams>();
                    var currentTeamAdd = new List<string>();
                    currentTeamAdd.Add(creator);
                    currentTeam.Add(new Teams
                    {
                        TeamName = team,
                        TeamMembers = currentTeamAdd
                    });
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                    teams = currentTeam;
                }                
            }
            string secondEntry = Console.ReadLine();
            while (secondEntry!="end of assignment")
            {
                
                var personEnroll = secondEntry
                    .Split(new string[]{ "->"},StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string newPerson = personEnroll[0];
                string desiredTeam = personEnroll[1];
                if (!teams.Select(x => x.TeamName).Contains(desiredTeam))
                {
                    Console.WriteLine($"Team {desiredTeam} does not exist!");
                }
                else
                {
                    var peopleList = new Teams();
                    peopleList= teams.First(x =>x.TeamName==desiredTeam);
                    if (teams.Any(x => x.TeamMembers.Contains(newPerson)) || teams.Any(x => x.Creator == newPerson))
                    {
                        Console.WriteLine($"Member {newPerson} cannot join team {desiredTeam}!");
                    }                    
                    else
                    {
                        peopleList.TeamMembers.Add(newPerson);
                        teams.Remove(peopleList);
                        teams.Add(peopleList);
                    }
                }
                secondEntry = Console.ReadLine();
            }
            foreach (var teamCreated in teams.OrderByDescending(x=>x.TeamMembers.Count).ThenBy(x=>x.TeamName))
            {
                if (teamCreated.TeamMembers.Count > 1)
                {
                    Console.WriteLine(teamCreated.TeamName);
                    Console.WriteLine($"- {teamCreated.Creator}");
                    foreach (var member in teamCreated.TeamMembers.OrderBy(x=>x))
                    {
                        if (member != teamCreated.Creator)
                        {
                            Console.WriteLine($"-- {member}");
                        }
                    }
                }            
            }
            Console.WriteLine("Teams to disband:");
            foreach (var teamWithLessPlayers in teams.OrderBy(x=>x.TeamName))
            {
                if (teamWithLessPlayers.TeamMembers.Count <= 1)
                {
                    Console.WriteLine(teamWithLessPlayers.TeamName);                    
                }
            }
        }
    }
}
