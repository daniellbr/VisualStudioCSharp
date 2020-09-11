using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Splunk
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ContainerConfiguration.Configure();

            var logger = serviceProvider.GetService<ILogger<Program>>();

            while (true)
            {
                logger.LogInformation($"Teste chamada Api Splunk {DateTime.Now}");
                Console.ReadLine();
            }
        }
    }
}
