namespace _1.Logger.Interfaces
{
    using _1.Logger.Enumerators;
    using System.Collections.Generic;

    public interface IAppender
    {
        void Info();

        void Append(SortedDictionary<int,string[]> info);

        ReportLevels ReportLevel { get; }

        ILayout Layout { get; }
    }
}