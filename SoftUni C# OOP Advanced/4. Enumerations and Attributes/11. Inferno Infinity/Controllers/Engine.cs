namespace _11.Inferno_Infinity.Controllers
{
    using System;
    using System.Linq;

    public class Engine
    {
        public void Run()
        {
            var commands = Console.ReadLine()
                .Split(new[] { ";"}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var weaponManager = new WeaponManager();
            while (commands[0] != "END")
            {
                switch (commands[0])
                {
                    case "Create":
                        weaponManager.Create(commands);
                        break;
                    case "Add":
                        weaponManager.Add(commands);
                        break;
                    case "Remove":
                        weaponManager.Remove(commands);
                        break;
                    case "Print":
                        weaponManager.Print(commands[1]);
                        break;
                }
                commands = Console.ReadLine()
                .Split(new[] { ";"}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            Console.WriteLine(weaponManager.sb.ToString().TrimEnd());
        }
    }
}