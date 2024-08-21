
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace GoogleAnalyticsAnalysis
{
    class Program
    {
        static string[] Scopes = { AnalyticsService.Scope.AnalyticsReadonly };
        static string ApplicationName = "Google Analytics Analysis";

        static void Main(string[] args)
        {
            GoogleCredential credential;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }

            var service = new AnalyticsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            string viewId = "YOUR_VIEW_ID"; // Replace this with your Google Analytics view ID

            var request = service.Data.Ga.Get(viewId, "30daysAgo", "today", "ga:users,ga:sessions,ga:pageviews");
            var data = request.Execute();

            Console.WriteLine("User behavior analysis for the past 30 days:");
            Console.WriteLine($"Total Users: {data.Rows[0][0]}");
            Console.WriteLine($"Total Sessions: {data.Rows[0][1]}");
            Console.WriteLine($"Total Pageviews: {data.Rows[0][2]}");

            Console.ReadLine();
        }
    }
}
