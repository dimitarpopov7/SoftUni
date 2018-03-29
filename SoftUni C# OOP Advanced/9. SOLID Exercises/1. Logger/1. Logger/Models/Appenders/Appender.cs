namespace _1.Logger.Models.Appenders
{
    using Interfaces;
    using System;
    using Enumerators;
    using Models.Layouts;
    using System.Linq;
    using System.Text;
    using _1.Logger.Models.IO;
    using System.Collections.Generic;

    public abstract class Appender : IAppender
    {
        private ReportLevels reportLevel;
        private ILayout layout;
        private IWriter writer = new Writer();
        internal int Size;

        public Appender(string layoutType)
        {
            ReportLevel = ReportLevels.Info;
            this.Layout = GetLayout(layoutType);
        }

        public Appender(string layoutType, string reportLevel)
        {
            reportLevel = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(reportLevel.ToLower());
            ReportLevel = (ReportLevels)Enum.Parse(typeof(ReportLevels), reportLevel);
            this.Layout = GetLayout(layoutType);
        }

        public ReportLevels ReportLevel { get { return this.reportLevel; } private set { this.reportLevel = value; } }

        public ILayout Layout { get { return this.layout; } private set { this.layout = value; } }

        private ILayout GetLayout(string layoutType)
        {
            Type type = Type.GetType(layoutType);
            var layoutAssembly = typeof(Layout).Assembly.GetTypes();
            foreach (var asm in layoutAssembly.Where(n => n.Name == layoutType))
            {
                ILayout layoutToReturn = (Layout)Activator.CreateInstance(asm, true);
                return layoutToReturn;
            }
            return null;
        }

        private int GetSize(string text)
        {
            string toBeAdded = "File size: ";
            byte[] asciBytes = Encoding.ASCII.GetBytes(text+toBeAdded);

            int size = 0;
            foreach (var character in asciBytes)
            {
                size += character;
            }
            return size;
        }

        public virtual void Info()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Appender type: {this.GetType().Name}" +
                $", Layout type: {this.Layout.GetType().Name}" +
                $", Report level: {this.ReportLevel.ToString().ToUpper()}" +
                $", Messages appended: {(int)this.ReportLevel}");
            var text = sb.ToString().TrimEnd();
            this.Size = GetSize(text);
            writer.Write(text);
        }

        public abstract void Append(SortedDictionary<int, string[]> info);
    }
}