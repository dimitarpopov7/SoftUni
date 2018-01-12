namespace _1.Avatar
{
    using System.Collections.Generic;
    using System.Text;
    using System;
    public class Nations
    {
        public static List<string> warList=new List<string>();

        public static Dictionary<string, List<Bender>> nationBenders = new Dictionary<string, List<Bender>>()
        {
            { "Air", new List<Bender>()},
            { "Water", new List<Bender>()},
            { "Fire", new List<Bender>()},
            { "Earth", new List<Bender>()}
        };
        public static Dictionary<string, List<Monuments>> nationMonuments = new Dictionary<string, List<Monuments>>()
        {
            { "Air",new List<Monuments>()},
            { "Water",new List<Monuments>()},
            { "Fire",new List<Monuments>()},
            { "Earth",new List<Monuments>()}
        };
                
        public string GetNationInfo(string type)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{type} Nation");
            sb.Append("Benders:");
            if (nationBenders[type].Count == 0)
            {
                sb.AppendLine("None");
            }
            else
            {
                sb.Append(Environment.NewLine);
                foreach (var bender in nationBenders[type])
                {
                    sb.AppendLine($"###{bender.ToString()}");
                }
            }
            sb.Append("Monuments:");
            if (nationMonuments[type].Count == 0)
            {
                sb.Append("None");
            }
            else
            {
                sb.Append(Environment.NewLine);
                foreach (var monument in nationMonuments[type])
                {
                    sb.AppendLine($"###{monument.ToString()}");
                }
            }
            return sb.ToString().TrimEnd('\r', '\n');
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            var warCounter = 1;
            foreach (var nationDeclaredWar in warList)
            {
                sb.AppendLine($"War {warCounter} issued by {nationDeclaredWar}.");
                warCounter++;
            }            
            return sb.ToString().TrimEnd('\r', '\n');
        }
    }
}