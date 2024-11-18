
using Google.Apis.Analytics.v3;
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
            string clientId = "YOUR_CLIENT_ID";
            string clientSecret = "YOUR_CLIENT_SECRET";
            string viewId = "YOUR_VIEW_ID";

            var credential = GoogleCredential.FromFile("credentials.json")
                .CreateScoped(new[] { AnalyticsService.Scope.AnalyticsReadonly });

            var service = new AnalyticsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential
            });

            var request = service.Data.Ga.Get("ga:" + viewId, DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd"),
                DateTime.Now.ToString("yyyy-MM-dd"), "ga:users");

            request.Dimensions = "ga:date";
            request.MaxResults = 10;

            var data = request.Execute();

            Console.WriteLine("User behavior analysis for the last 7 days:");
            Console.WriteLine("Date\t\tUsers");

            foreach (var row in data.Rows)
            {
                Console.WriteLine($"{row[0]}\t{row[1]}");
            }
        }
    }
}
