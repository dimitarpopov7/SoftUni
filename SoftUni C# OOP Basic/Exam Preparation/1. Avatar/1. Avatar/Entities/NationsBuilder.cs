namespace _1.Avatar
{    
    using System.Collections.Generic;
    using System.Linq;
    public class NationsBuilder
    {
        public void AssignBender(List<string> benderArgs)
        {
            var type = benderArgs[1];
            var name = benderArgs[2];
            var power = int.Parse(benderArgs[3]);
            var secondaryParameter = float.Parse(benderArgs[4]);
            switch (type)
            {
                case "Air":
                    var airBender = new AirBender(name, power, secondaryParameter);
                    Nations.nationBenders[type].Add(airBender);
                    break;
                case "Water":
                    var waterBender = new WaterBender(name, power, secondaryParameter);
                    Nations.nationBenders[type].Add(waterBender);
                    break;
                case "Fire":
                    var fireBender = new FireBender(name, power, secondaryParameter);
                    Nations.nationBenders[type].Add(fireBender);
                    break;
                case "Earth":
                    var earthBender = new EarthBender(name, power, secondaryParameter);
                    Nations.nationBenders[type].Add(earthBender);
                    break;
            }
        }
        public void AssignMonument(List<string> monumentArgs)
        {
            var type = monumentArgs[1];
            var name = monumentArgs[2];
            var affinity = int.Parse(monumentArgs[3]);
            switch (type)
            {
                case "Air":
                    var airMonument = new AirMonument(name, affinity);
                    Nations.nationMonuments[type].Add(airMonument);
                    break;
                case "Water":
                    var waterMonument = new WaterMonument(name, affinity);
                    Nations.nationMonuments[type].Add(waterMonument);
                    break;
                case "Fire":
                    var fireMonument = new FireMonument(name, affinity);
                    Nations.nationMonuments[type].Add(fireMonument);
                    break;
                case "Earth":
                    var earthMonument = new EarthMonument(name, affinity);
                    Nations.nationMonuments[type].Add(earthMonument);
                    break;
            }
        }
        public string GetStatus(string nationsType)
        {
            var nation = new Nations();            
            return nation.GetNationInfo(nationsType).ToString();
        }
        public void IssueWar(string nationsType)
        {
            Nations.warList.Add(nationsType);

            var airPower = Nations.nationBenders["Air"].Sum(x => x.TotalPower) 
                + Nations.nationBenders["Air"].Sum(x => x.TotalPower) * (Nations.nationMonuments["Air"].Sum(x => x.BonusPower) / 100);

            var waterPower = Nations.nationBenders["Water"].Sum(x => x.TotalPower)
                + Nations.nationBenders["Water"].Sum(x => x.TotalPower) * (Nations.nationMonuments["Water"].Sum(x => x.BonusPower) / 100);

            var firePower = Nations.nationBenders["Fire"].Sum(x => x.TotalPower) 
                + Nations.nationBenders["Fire"].Sum(x => x.TotalPower) * (Nations.nationMonuments["Fire"].Sum(x => x.BonusPower) / 100);

            var earthPower = Nations.nationBenders["Earth"].Sum(x => x.TotalPower)
                + Nations.nationBenders["Earth"].Sum(x => x.TotalPower) * (Nations.nationMonuments["Earth"].Sum(x => x.BonusPower) / 100);

            var powersList = new Dictionary<string,double>() { {"Air", airPower },{ "Water", waterPower },{ "Fire", firePower },{ "Earth", earthPower } };

            var strongestNation = powersList.OrderByDescending(TotalPower=>TotalPower.Value).Select(Type=>Type.Key).FirstOrDefault();

            foreach (var nation in Nations.nationBenders.Where(name=>name.Key!=strongestNation))
            {
                nation.Value.Clear();
            }
            foreach (var nation in Nations.nationMonuments.Where(name=>name.Key!=strongestNation))
            {
                nation.Value.Clear();
            }
        }
        public string GetWarsRecord()
        {
            var nations = new Nations();
            return nations.ToString();
        }

    }
}