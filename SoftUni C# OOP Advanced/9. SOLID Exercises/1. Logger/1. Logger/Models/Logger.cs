namespace _1.Logger.Models
{
    using _1.Logger.Interfaces;
    using System.Collections.Generic;

    public class Logger : ILogger
    {
        public IAppender Appender { get; set; }
        private const string separator = " - ";
        private SortedDictionary<int,string[]> message;
        private IWriter writer;

        public Logger(IAppender appenderType)
        {
            this.Appender = appenderType;
            this.Messages = new SortedDictionary<int, string[]>();
        }

        public SortedDictionary<int,string[]> Messages { get { return this.message; } private set { this.message = value; } }

        public void Fatal(string date, string msg)
        {
            var line = new string[3] { date, "FATAL", msg };
            Messages.Add(4,line);
        }

        public void Critical(string date, string msg)
        {
            var line = new string[3] { date, "CRITICAL" ,msg };
            Messages.Add(3,line);

        }

        public void Warning(string date, string msg)
        {
            var line = new string[3] { date, "WARRNING", msg };
            Messages.Add(2,line);
        }

        public void Error(string date, string msg)
        {
            var line = new string[3] { date, "ERROR", msg };
            Messages.Add(1,line);
        }

        public void Info(string date, string msg)
        {
            var line = new string[3] { date, "INFO", msg };
            Messages.Add(0,line);
        }

        public void LayoutOutput()
        {
            this.Appender.Append(Messages);
        }

        public void InfoSummary()
        {
            this.Appender.Info();
        }
    }
}