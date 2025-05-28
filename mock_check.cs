
using Google.Apis.AnalyticsReporting.v4;
using Google.Apis.AnalyticsReporting.v4.Data;
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
            // Initialize the Analytics Service
            var credential = GoogleCredential.FromFile("path-to-your-credentials-file.json")
                .CreateScoped(new[] { AnalyticsReportingService.Scope.AnalyticsReadonly });
            
            var service = new AnalyticsReportingService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential
            });

            // Set the View ID for the website you want to analyze
            string viewId = "your-view-id";

            // Create the Date Range
            var dateRange = new DateRange
            {
                StartDate = "2022-01-01",
                EndDate = "2022-01-31"
            };

            // Create the Metrics
            var sessions = new Metric
            {
                Expression = "ga:sessions",
                Alias = "Sessions"
            };

            // Create the Report Request
            var reportRequest = new ReportRequest
            {
                ViewId = viewId,
                DateRanges = new List<DateRange> { dateRange },
                Metrics = new List<Metric> { sessions }
            };

            // Create the Get Reports Request
            var getReport = new GetReportsRequest
            {
                ReportRequests = new List<ReportRequest> { reportRequest }
            };

            // Get the Report Response
            var response = service.Reports.BatchGet(getReport).Execute();

            // Print the Report Data
            foreach (var report in response.Reports)
            {
                foreach (var row in report.Data.Rows)
                {
                    foreach (var metric in row.Metrics)
                    {
                        foreach (var values in metric.Values)
                        {
                            Console.WriteLine(values);
                        }
                    }
                }
            }
        }
    }
}
