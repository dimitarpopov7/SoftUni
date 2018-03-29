namespace _1.Logger.Models.Layouts
{
    using Interfaces;
    using Models.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SimpleLayout : Layout
    {
        private IWriter writer = new Writer();


        public override string Format(SortedDictionary<int,string[]> info, int numberOfLinesToTake)
        {
            info.OrderByDescending(v => v.Value);

            var sb = new StringBuilder();

            foreach (var infoLine in info.Values.Skip(5-numberOfLinesToTake).Take(numberOfLinesToTake))
            {
                sb.AppendLine($"{infoLine[1]} - {infoLine[0]} - {infoLine[2]}");
            }
            return sb.ToString().TrimEnd();
            writer.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
