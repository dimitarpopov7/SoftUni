namespace _8.Military_Elite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using _8.Military_Elite.Interfaces;
    using _8.Military_Elite.Soldiers.SpecialSoldiers;
    using _8.Military_Elite.Soldiers.Spies;
    using _8.Military_Elite.Missions;
    using _8.Military_Elite.Repairs;
    public class StartUp
    {
        public static void Main()
        {
            var engine = new Engine();

            var entry = Console.ReadLine();
            var sb = new StringBuilder();
            var privateList = new List<IPrivate>();
            
            while (entry != "End")
            {
                try
                {
                    var soldierInfo = entry.Split().ToList();
                    var type = soldierInfo[0];
                    var id = soldierInfo[1];
                    var firstName = soldierInfo[2];
                    var lastName = soldierInfo[3];
                    double salary;
                    string corps;

                    switch (type)
                    {
                        case "Private":
                            salary = double.Parse(soldierInfo[4]);
                            var currentPrivate = new Private(firstName, lastName, id, salary);
                            privateList.Add(currentPrivate);
                            sb.AppendLine(currentPrivate.ToString());
                            break;
                        case "LeutenantGeneral":
                            var leutanantsPrivates = new List<IPrivate>();
                            for (int numOfPrivates = 0; numOfPrivates < soldierInfo.Count - 5; numOfPrivates++)
                            {
                                IPrivate currentPrivateToAdd = privateList.FirstOrDefault(x => x.ID == soldierInfo[5 + numOfPrivates]);
                                leutanantsPrivates.Add(currentPrivateToAdd);
                            }
                            var leutenantGeneral = new LeutanantGeneral(firstName, lastName, id, double.Parse(soldierInfo[4]), leutanantsPrivates);
                            sb.AppendLine(leutenantGeneral.ToString());
                            break;
                        case "Engineer":
                            salary = double.Parse(soldierInfo[4]);
                            corps = soldierInfo[5];
                            var numOfRepairs = (soldierInfo.Count - 5) / 2;
                            var listRepairs = new List<Repair>();
                            var index = 0;
                            for (int i = 0; i < numOfRepairs; i++)
                            {
                                var repairName = soldierInfo[6 + index];
                                var repairWorkinHours = int.Parse(soldierInfo[7 + index]);
                                var repair = new Repair(repairName, repairWorkinHours);
                                listRepairs.Add(repair);
                                index += 2;
                            }
                            var currentEngineer = new Engineer(firstName, lastName, id, salary, corps, listRepairs);
                            sb.AppendLine(currentEngineer.ToString());
                            break;
                        case "Commando":
                            salary = double.Parse(soldierInfo[4]);
                            corps = soldierInfo[5];
                            var numOfMissions = (soldierInfo.Count - 5) / 2;
                            var missionsList = new List<Mission>();
                            var missionIndex = 0;
                            for (int i = 0; i < numOfMissions; i++)
                            {
                                var missionName = soldierInfo[6 + missionIndex];
                                var missionStatus = soldierInfo[7 + missionIndex];
                                var mission = new Mission(missionName, missionStatus);
                                missionsList.Add(mission);
                                missionIndex += 2;
                            }
                            var currentCommando = new Commando(firstName, lastName, id, salary, corps, missionsList);
                            sb.AppendLine(currentCommando.ToString());
                            break;
                        case "Spy":
                            var codeNumber = soldierInfo[4];
                            var currentSpy = new Spy(firstName, lastName, id, codeNumber);
                            sb.AppendLine(currentSpy.ToString());
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                entry = Console.ReadLine();
            }
            Console.WriteLine(sb.ToString().TrimEnd('\n'));
        }
    }
}