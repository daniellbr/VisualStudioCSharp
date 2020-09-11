using Microsoft.Extensions.DependencyInjection;
using NLog.Extensions.Logging;
using Microsoft.Extensions.Logging;
using System;
using NLog;
using NLog.Common;

namespace Splunk
{
    internal static class ContainerConfiguration
    {
        public static IServiceProvider Configure()
        {
            var serviceCollection = new ServiceCollection();

            LogManager.LoadConfiguration("nlog.xml");
            InternalLogger.LogToConsole = true;
            InternalLogger.LogLevel = NLog.LogLevel.Trace;

            serviceCollection.AddLogging(log =>
            {
                log.ClearProviders();
                log.AddNLog();
            }).Configure<LoggerFilterOptions>(conf => conf.MinLevel = Microsoft.Extensions.Logging.LogLevel.Trace);

            return serviceCollection.BuildServiceProvider();
        }
    }
}
