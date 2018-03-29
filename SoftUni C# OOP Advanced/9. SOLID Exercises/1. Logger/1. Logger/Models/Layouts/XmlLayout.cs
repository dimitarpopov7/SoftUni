namespace _1.Logger.Models.Layouts
{
    using Interfaces;
    using Models.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class XmlLayout : Layout
    {
        private IWriter writer = new Writer();
        public override string Format(SortedDictionary<int,string[]> info, int numberOfLinesToTake)
        {
            info.OrderByDescending(v => v.Value);

            var sb = new StringBuilder();

            sb.AppendLine("<log>");
            foreach (var infoLine in info.Values.Skip(5-numberOfLinesToTake).Take(numberOfLinesToTake))
            {
                sb.AppendLine($"    <date>{infoLine[1]}</date>");
                sb.AppendLine($"    <level>{infoLine[0]}</level>");
                sb.AppendLine($"    <message>{infoLine[2]}</message>");
            }
            sb.AppendLine("</log>");
            return sb.ToString().TrimEnd();
        }
    }
}
