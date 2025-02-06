
using Google.Apis.AnalyticsReporting.v4;
using Google.Apis.AnalyticsReporting.v4.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace GoogleAnalyticsAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string viewId = "YOUR_VIEW_ID";
            string[] scopes = { AnalyticsReportingService.Scope.AnalyticsReadonly };
            string applicationName = "Google Analytics Analysis";

            GoogleCredential credential;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(scopes);
            }

            var service = new AnalyticsReportingService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });

            DateRange dateRange = new DateRange
            {
                StartDate = "7DaysAgo",
                EndDate = "today"
            };

            Metric sessions = new Metric
            {
                Expression = "ga:sessions",
                Alias = "Sessions"
            };

            ReportRequest request = new ReportRequest
            {
                ViewId = viewId,
                DateRanges = new List<DateRange> { dateRange },
                Metrics = new List<Metric> { sessions }
            };

            List<ReportRequest> requests = new List<ReportRequest> { request };

            GetReportsRequest getReport = new GetReportsRequest
            {
                ReportRequests = requests
            };

            GetReportsResponse response = service.Reports.BatchGet(getReport).Execute();

            foreach (Report report in response.Reports)
            {
                foreach (ReportRow row in report.Data.Rows)
                {
                    Console.WriteLine("Date Range: " + row.Keys[0]);
                    foreach (string value in row.Metrics[0].Values)
                    {
                        Console.WriteLine("Sessions: " + value);
                    }
                }
            }
        }
    }
}
