namespace _11.Inferno_Infinity.Controllers
{
    using Models;
    using Models.Weapons;
    using Models.Gems;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WeaponManager
    {
        public List<Weapon> weaponsList = new List<Weapon>();
        public StringBuilder sb = new StringBuilder();

        public void Create(List<string> createArguments)
        {
            var weaponInfo = createArguments[1].Split();
            string weaponRarity = weaponInfo[0];
            string weaponType = weaponInfo[1];
            string weaponName = createArguments[2];
            switch (weaponType)
            {
                case "Axe":
                    Axe axe = new Axe(weaponName, weaponRarity);
                    weaponsList.Add(axe);
                    break;
                case "Sword":
                    Sword sword = new Sword(weaponName, weaponRarity);
                    weaponsList.Add(sword);
                    break;
                case "Knife":
                    Knife knife = new Knife(weaponName, weaponRarity);
                    weaponsList.Add(knife);
                    break;
            }
        }
        public void Add(List<string> addArguments)
        {
            var gemInfo = addArguments[3].Split();
            string weaponName = addArguments[1];
            int socketIndex = int.Parse(addArguments[2]);
            string gemClarity = gemInfo[0];
            string gemType = gemInfo[1];

            Weapon weaponToBeCrafted = GetWeapon(weaponName);
            if (socketIndex >= 0 && socketIndex <= weaponToBeCrafted.Sockets.Length-1)
            {
                switch (gemType)
                {
                    case "Ruby":
                        Ruby ruby = new Ruby(gemClarity);
                        weaponToBeCrafted.Sockets[socketIndex] = ruby;
                        break;
                    case "Emerald":
                        Emerald emerald = new Emerald(gemClarity);
                        weaponToBeCrafted.Sockets[socketIndex] = emerald;
                        break;
                    case "Amethyst":
                        Amethyst amethyst = new Amethyst(gemClarity);
                        weaponToBeCrafted.Sockets[socketIndex] = amethyst;
                        break;
                }

            }
            weaponsList.Add(weaponToBeCrafted);
        }

        public void Remove(List<string> removeArguments)
        {
            string weaponName= removeArguments[1];
            int socketIndex = int.Parse(removeArguments[2]);

            Weapon weaponToBeCrafted = GetWeapon(weaponName);
            if(socketIndex >= 0 && socketIndex <= weaponToBeCrafted.Sockets.Length-1)
            {
                weaponToBeCrafted.Sockets[socketIndex] = null;
            }
            weaponsList.Add(weaponToBeCrafted);
        }
        public void Print(string weaponName)
        {
            Weapon weaponToPrint = this.weaponsList.FirstOrDefault(w => w.Name == weaponName);
            sb.AppendLine(weaponToPrint.ToString());
        }
        private Weapon GetWeapon(string weaponName)
        {
            var weaponToBeCrafted = weaponsList.FirstOrDefault(w => w.Name == weaponName);
            weaponsList.Remove(weaponToBeCrafted);
            return weaponToBeCrafted;
        }
    }
}