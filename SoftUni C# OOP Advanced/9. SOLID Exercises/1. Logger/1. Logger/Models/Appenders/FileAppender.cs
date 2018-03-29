namespace _1.Logger.Models.Appenders
{
    using _1.Logger.Interfaces;
    using _1.Logger.Models.IO;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FileAppender : Appender
    {
        private IWriter writer = new Writer();

        public FileAppender(string layoutType) : base(layoutType)
        {
        }

        public FileAppender(string layoutType, string reportLevel) : base(layoutType, reportLevel)
        {
        }

        public override void Append(SortedDictionary<int, string[]> info)
        {
            File.WriteAllText(@"C:\Users\dimit\OneDrive\Documents\Visual Studio 2017\Projects\1. Logger\1. Logger\Models\Appenders\File.txt", this.Layout.Format(info, (int)this.ReportLevel));
        }

        public override void Info()
        {
            base.Info();
            writer.WriteLine($" File size: {Convert.ToString(base.Size)}");          
        }
    }
}
