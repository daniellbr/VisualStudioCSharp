using KissLog;
using KissLog.AspNetCore;
using KissLog.CloudListeners.Auth;
using KissLog.CloudListeners.RequestLogsListener;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.Text;

namespace AspNetCoreIdentity.Config
{
    public class LogConfig
    {
        public void ConfigureKissLog(IOptionsBuilder options, IConfiguration configuration)
        {
            // optional KissLog configuration
            options.Options
                .AppendExceptionDetails((Exception ex) =>
                {
                    StringBuilder sb = new StringBuilder();

                    if (ex is System.NullReferenceException nullRefException)
                    {
                        sb.AppendLine("Important: check for null references");
                    }

                    return sb.ToString();
                });

            // KissLog internal logs
            options.InternalLog = (message) =>
            {
                Debug.WriteLine(message);
            };

            RegisterKissLogListeners(options, configuration);
            //RegisterKissLogListeners(configuration);
        }


        //public static void RegisterKissLogListeners(IConfiguration configuration)
        //{
        //    KissLogConfiguration.Listeners.Add(new RequestLogsApiListener(new Application(
        //          configuration["KissLog.OrganizationId: 15cc07da-9159-4bc6-b5ed-84992261c33c"],
        //          configuration["KissLog.ApplicationId: 43239184-5f2c-4341-8a29-36974095e69c"]
        //    ))
        //    {
        //        ApiUrl = configuration["KissLog.ApiUrl"]    //  "https://api.kisslog.net"
        //    });
        //}

        public static void RegisterKissLogListeners(IOptionsBuilder options, IConfiguration configuration)
        {
            options.Listeners.Add(new RequestLogsApiListener(new Application(
            configuration["KissLog.OrganizationId"],    //  "15cc07da-9159-4bc6-b5ed-84992261c33c"
            configuration["KissLog.ApplicationId"])     //  "43239184-5f2c-4341-8a29-36974095e69c"
            )
            {
                ApiUrl = configuration["KissLog.ApiUrl"]    //  "https://api.kisslog.net"
            });
        }
    }
}
