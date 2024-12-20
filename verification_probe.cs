
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System;
using System.Collections.Generic;

namespace GoogleAnalyticsAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string viewId = "YOUR_VIEW_ID";
            string applicationName = "YOUR_APPLICATION_NAME";
            string keyFilePath = "YOUR_KEY_FILE_PATH";

            var credential = GoogleCredential.FromFile(keyFilePath)
                .CreateScoped(new[] { AnalyticsService.Scope.AnalyticsReadonly });

            var service = new AnalyticsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });

            var request = service.Data.Ga.Get(viewId, "yesterday", "today", "ga:pageviews");
            var data = request.Execute();

            if (data.Rows != null)
            {
                foreach (var row in data.Rows)
                {
                    Console.WriteLine($"Page path: {row[0]}, Pageviews: {row[1]}");
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }
    }
}
