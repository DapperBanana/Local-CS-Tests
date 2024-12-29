
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System;
using System.Collections.Generic;

namespace GoogleAnalyticsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string applicationName = "Google Analytics API";
            string keyFilePath = "YOUR_KEY_FILE_PATH.json";
            string viewId = "YOUR_VIEW_ID";
            string startDate = "2022-01-01";
            string endDate = "2022-01-31";
            
            // Create OAuth credential
            GoogleCredential credential;
            using (var stream = new System.IO.FileStream(keyFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(new string[] { AnalyticsService.Scope.Analytics });
            }

            // Create Analytics service
            var service = new AnalyticsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });

            // Get the report data
            var request = service.Data.Ga.Get("ga:" + viewId, startDate, endDate, "ga:users,ga:pageviews");
            request.Dimensions = "ga:pagePath";
            var report = request.Execute();

            // Display the report data
            Console.WriteLine("Page Path\tUsers\tPageviews");
            foreach (var row in report.Rows)
            {
                Console.WriteLine($"{row[0]}\t{row[1]}\t{row[2]}");
            }
        }
    }
}
