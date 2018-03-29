namespace _1.Logger.Models.Appenders
{
    using Interfaces;
    using Models.IO;
    using System;
    using System.Collections.Generic;

    public class ConsoleAppender : Appender
    {
        IWriter writer=new Writer();
        public ConsoleAppender(string layoutType) : base(layoutType)
        {

        }

        public ConsoleAppender(string layoutType, string reportLevel) : base(layoutType, reportLevel)
        {

        }
        
        public override void Append(SortedDictionary<int, string[]> info)
        {
            writer.WriteLine(this.Layout.Format(info, (int)this.ReportLevel));
        }

        public override void Info()
        {
            base.Info();
            writer.Write(Environment.NewLine);
        }
    }
}
