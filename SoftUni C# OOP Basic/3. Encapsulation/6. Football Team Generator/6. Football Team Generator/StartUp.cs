namespace _6.Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {            
            var command = Console.ReadLine().Split(';').ToList();
            var teams = new List<FootbalTeam>();
            while (command[0] != "END")
            {
                try
                {
                    if (command[0] == "Team")
                    {
                        var currentTeam = new FootbalTeam(command[1]);
                        teams.Add(currentTeam);
                    }
                    else if (command[0] == "Add")
                    {
                        var teamName = command[1];
                        var check = teams.FirstOrDefault(t => t.Name == teamName);
                        if (check == null)
                        {
                            Console.WriteLine($"Team {command[1]} does not exist.");
                        }
                        else
                        {
                            var playerName = command[2];
                            var endurance = int.Parse(command[3]);
                            var sprint = int.Parse(command[4]);
                            var dribble = int.Parse(command[5]);
                            var passing = int.Parse(command[6]);
                            var shooting = int.Parse(command[7]);
                            var currentPlayer = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                            teams.FirstOrDefault(x => x.Name == teamName).Players.Add(currentPlayer);
                        }                      
                    }
                    else if (command[0] == "Remove")
                    {
                        var teamToLook = command[1];
                        var playerToRemove = teams.FirstOrDefault(t=>t.Name==teamToLook).Players.FirstOrDefault(p=>p.Name==command[2]);
                        if (teams.FirstOrDefault(x => x.Name == teamToLook).Players.Contains(playerToRemove))
                        {
                            teams.FirstOrDefault(x => x.Name == teamToLook).Players.Remove(playerToRemove);
                        }
                        else
                        {
                            Console.WriteLine($"Player {command[2]} is not in {teamToLook} team.");
                        }                        
                    }
                    else if (command[0] == "Rating")
                    {
                        var teamToLook = teams.FirstOrDefault(t=>t.Name==command[1]);
                        if (teams.Contains(teamToLook))
                        {
                            double rating = teamToLook.GetAverageRating();
                            Console.WriteLine($"{teamToLook.Name} - {rating}");
                        }
                        else
                        {
                            Console.WriteLine($"Team {command[1]} does not exist.");
                        }
                    }                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                command = Console.ReadLine().Split(';').ToList();
            }
        }
    }
}