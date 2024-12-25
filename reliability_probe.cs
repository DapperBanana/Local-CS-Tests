
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Google.Apis.AnalyticsReporting.v4;
using Google.Apis.AnalyticsReporting.v4.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;

namespace GoogleAnalyticsAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string viewId = "YOUR_VIEW_ID";

            GoogleCredential credential;
            using (var stream = new FileStream("service_account.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(AnalyticsReportingService.Scope.AnalyticsReadonly);
            }

            var service = new AnalyticsReportingService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential
            });

            var request = new GetReportsRequest
            {
                ReportRequests = new[]
                {
                    new ReportRequest
                    {
                        ViewId = viewId,
                        DateRanges = new[] { new DateRange { StartDate = "7daysAgo", EndDate = "today" } },
                        Metrics = new[] { new Metric { Expression = "ga:sessions" } },
                        Dimensions = new[] { new Dimension { Name = "ga:pagePath" } }
                    }
                }
            };

            var response = service.Reports.BatchGet(request).Execute();

            if (response.Reports != null)
            {
                foreach (var report in response.Reports)
                {
                    foreach (var row in report.Data.Rows)
                    {
                        Console.WriteLine($"Page: {row.Dimensions[0]} - Sessions: {row.Metrics[0].Values[0]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No data found");
            }
        }
    }
}
