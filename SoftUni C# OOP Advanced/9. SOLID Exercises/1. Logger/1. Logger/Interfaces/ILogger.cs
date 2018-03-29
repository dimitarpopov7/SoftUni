namespace _1.Logger.Interfaces
{
    using System.Collections.Generic;

    public interface ILogger
    {
        IAppender Appender { get; }
        SortedDictionary<int,string[]> Messages { get; }

        void LayoutOutput();
        void InfoSummary();
        void Warning(string date, string msg);
        void Error(string date, string msg);
        void Fatal(string date, string msg);
        void Info(string date, string msg);
        void Critical(string date, string msg);
    }
}
