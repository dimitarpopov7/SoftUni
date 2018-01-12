namespace _1.Avatar
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            while (command!="Quit")
            {
                var info = command.Split().ToList();
                var nationsBuilder = new NationsBuilder();
                if (command.StartsWith("Bender"))
                {
                    nationsBuilder.AssignBender(info);
                }
                else if (command.StartsWith("Monument"))
                {
                    nationsBuilder.AssignMonument(info);
                }
                else if (command.StartsWith("Status"))
                {
                    Console.WriteLine(nationsBuilder.GetStatus(info[1]));
                }
                else if (command.StartsWith("War"))
                {
                    nationsBuilder.IssueWar(info[1]);
                }
                command = Console.ReadLine();
            }
            var natBuilder = new NationsBuilder();
            Console.WriteLine(natBuilder.GetWarsRecord());
        }
    }
}