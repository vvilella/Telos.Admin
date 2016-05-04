using System;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace Telos.Admin.Infrastructure
{
    public class Log
    {
        static Log()
        {
            var builder = new ConfigurationSourceBuilder();

            builder.ConfigureLogging()
                   .LogToCategoryNamed("General")
                     .WithOptions.SetAsDefaultCategory()
                     .SendTo.FlatFile("Log File")
                       .FormatWith(new FormatterBuilder()
                         .TextFormatterNamed("Text Formatter")
                           .UsingTemplate("{message}{newline}"))
                         .ToFile("AppLog.txt");

            var configSource = new DictionaryConfigurationSource();
            builder.UpdateConfigurationWithReplace(configSource);
            EnterpriseLibraryContainer.Current
              = EnterpriseLibraryContainer.CreateDefaultContainer(configSource);
        }
            
        public static void Write(string msg)
        {
            LogEntry le = new LogEntry { Message = msg };
            Logger.Write(le);
        }
        public static void Write(string format, params object[] args)
        {
            Write(String.Format(format, args));
        }
    }
}
