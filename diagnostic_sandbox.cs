
using Google.Apis.AnalyticsReporting.v4;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace GoogleAnalyticsDemo
{
    class Program
    {
        static string[] Scopes = { AnalyticsReportingService.Scope.AnalyticsReadonly };
        static string ApplicationName = "Google Analytics C# Demo";

        static void Main(string[] args)
        {
            UserCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            var service = new AnalyticsReportingService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            var startDate = "2022-01-01";
            var endDate = "2022-01-31";
            var metrics = new List<Metric>
            {
                new Metric
                {
                    Expression = "ga:users",
                    Alias = "Users"
                }
            };
            var request = new GetReportsRequest
            {
                ReportRequests = new List<ReportRequest>
                {
                    new ReportRequest
                    {
                        ViewId = "YOUR_VIEW_ID",
                        DateRanges = new List<DateRange> { new DateRange { StartDate = startDate, EndDate = endDate } },
                        Metrics = metrics
                    }
                }
            };

            var response = service.Reports.BatchGet(request).Execute();

            foreach (var report in response.Reports)
            {
                foreach (var row in report.Data.Rows)
                {
                    Console.WriteLine($"Users: {row.Metrics[0].Values[0]}");
                }
            }
        }
    }
}
