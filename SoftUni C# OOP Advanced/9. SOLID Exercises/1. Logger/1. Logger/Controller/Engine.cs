namespace _1.Logger.Controller
{
    using Models;
    using System;
    using Models.IO;
    using Interfaces;
    using System.Collections.Generic;
    using _1.Logger.Models.Appenders;
    using System.Linq;
    using System.Reflection;

    public class Engine
    {
        IReader reader = new Read();
        IWriter writer = new Writer();
        private string appender;
        private string layout;
        private string reportLevel;
        List<ILogger> loggersList = new List<ILogger>();
        List<IAppender> appenderList = new List<IAppender>();
        MethodInfo[] loggerMethods = typeof(Logger).GetMethods();

        public void Run()
        {
            int numOfAppenders = int.Parse(reader.ReadLine());

            for (int i = 0; i < numOfAppenders; i++)
            {
                var infoArgs = reader.ReadLine().Split();
                IAppender currentAppender = GetAppender(infoArgs);
                var logger = new Logger(currentAppender);
                loggersList.Add(logger);
            }

            var logInfo = reader.ReadLine().Split('|');
            while (logInfo[0]!="END")
            {
                var reportLevel= System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(logInfo[0].ToLower());
                var date = logInfo[1];
                var msg = logInfo[2];
                var parameters = new string[] { date, msg };
                foreach (var logger in this.loggersList)
                {
                    foreach (var method in loggerMethods.Where(n=>n.Name==reportLevel))
                    {
                        method.Invoke(logger, parameters);
                    }
                }
                logInfo = reader.ReadLine().Split('|');
            }
            //Layout write

            foreach (var log in loggersList)
            {
                log.LayoutOutput();
            }

            writer.WriteLine("Logger info");

            foreach (var logger in loggersList)
            {
                logger.InfoSummary();
            }
        }

        private IAppender GetAppender(string[] infoArgs)
        {
            this.appender = infoArgs[0];
            this.layout = infoArgs[1];
            if (infoArgs.Length > 2)
            {
                this.reportLevel = infoArgs[2];
            }
            Type type = Type.GetType(appender);
            var appenderAssembly = typeof(Appender).Assembly.GetTypes();
            foreach (var asm in appenderAssembly.Where(n => n.Name == this.appender))
            {
                if (infoArgs.Length > 2)
                {
                    IAppender appenderToReturn = (Appender)Activator.CreateInstance(asm, this.layout, reportLevel);
                    return appenderToReturn;
                }
                else
                {
                    IAppender appenderToReturn= (Appender)Activator.CreateInstance(asm, layout);
                    return appenderToReturn;
                }
            }
            return null;
        }
    }
}
