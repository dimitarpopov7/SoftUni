namespace _1.Need_For_Speed
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            while (command != "Cops Are Here")
            {
                var info = command.Split().ToList();
                if (info[0] == "register")
                {
                    CarManager.Register(
                        int.Parse(info[1]),
                        info[2],
                        info[3],
                        info[4],
                        int.Parse(info[5]),
                        int.Parse(info[6]),
                        int.Parse(info[7]),
                        int.Parse(info[8]),
                        int.Parse(info[9]));
                }
                else if (info[0] == "check")
                {
                    Console.WriteLine(CarManager.Check(int.Parse(info[1])));
                }
                else if (info[0] == "open")
                {
                    if (info.Count > 6)
                    {
                        CarManager.OpenSpecial(
                        int.Parse(info[1]),
                        info[2],
                        int.Parse(info[3]),
                        info[4],
                        int.Parse(info[5]),
                        int.Parse(info[6]));
                    }
                    else
                    {
                        CarManager.Open(
                        int.Parse(info[1]),
                        info[2],
                        int.Parse(info[3]),
                        info[4],
                        int.Parse(info[5]));
                    }                                        
                }
                else if (info[0] == "participate")
                {
                    CarManager.Participate(int.Parse(info[1]), int.Parse(info[2]));
                }
                else if (info[0] == "start")
                {
                    Console.WriteLine(CarManager.Start(int.Parse(info[1])));
                }
                else if (info[0] == "park")
                {
                    try
                    {
                        CarManager.Park(int.Parse(info[1]));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (info[0] == "unpark")
                {
                    CarManager.Unpark(int.Parse(info[1]));
                }
                else if (info[0] == "tune")
                {
                    CarManager.Tune(int.Parse(info[1]), info[2]);
                }
                command = Console.ReadLine();
            }
        }
    }
}