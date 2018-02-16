using System;

namespace _8.Pet_Clinics
{
    public class StartUp
    {
        public static void Main()
        {
            var appManager = new ApplicationManager();

            int n = int.Parse(Console.ReadLine());
            Run(appManager, n);
        }

        private static void Run(ApplicationManager appManager, int n)
        {
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Create":
                        if (command[1] == "Pet")
                        {
                            appManager.CreatePet(command[2], int.Parse(command[3]), command[4]);
                        }
                        else
                        {
                            try
                            {
                                appManager.CreateClinic(command[2], int.Parse(command[3]));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case "Add":
                        bool result = appManager.AddPet(command[1], command[2]);
                        Console.WriteLine(result);
                        break;
                    case "HasEmptyRooms":
                        bool hasEmpty = appManager.HasEmptyRoom(command[1]);
                        Console.WriteLine(hasEmpty);
                        break;
                    case "Release":
                        bool resultRelease = appManager.ReleasePet(command[1]);
                        Console.WriteLine(resultRelease);
                        break;
                    case "Print":
                        if (command.Length > 2)
                        {
                            appManager.Print(command[1], int.Parse(command[2]));
                        }
                        else
                        {
                            appManager.Print(command[1]);
                        }
                        break;
                }
            }
        }
    }
}
