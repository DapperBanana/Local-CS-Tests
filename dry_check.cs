using System;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.AnalyticsReporting.v4;
using Google.Apis.AnalyticsReporting.v4.Data;

class Program
{
    static async Task Main(string[] args)
    {
        // Path to your service account credentials JSON file
        string credentialsPath = "path/to/your/service-account-credentials.json";

        // The ID of the view (profile) you want to analyze
        string viewId = "YOUR_VIEW_ID";

        // Authenticate and create the Analytics Reporting service
        var credential = GoogleCredential.FromFile(credentialsPath)
                                        .CreateScoped(AnalyticsReportingService.Scope.AnalyticsReadonly);

        var service = new AnalyticsReportingService(new BaseClientService.Initializer()
        {
            Credentials = credential,
            ApplicationName = "Website Behavior Analysis"
        });

        // Create the date range for the report
        var dateRange = new DateRange
        {
            StartDate = "30DaysAgo",
            EndDate = "today"
        };

        // Define the metrics to analyze user behavior, e.g., sessions, users, pageviews
        var metrics = new[]
        {
            new Metric { Expression = "ga:sessions", Alias = "Sessions" },
            new Metric { Expression = "ga:users", Alias = "Users" },
            new Metric { Expression = "ga:pageviews", Alias = "PageViews" },
            new Metric { Expression = "ga:avgSessionDuration", Alias = "AvgSessionDuration" }
        };

        // Optional: Define dimensions, e.g., pagePath to analyze behavior per page
        var dimensions = new[]
        {
            new Dimension { Name = "ga:pagePath" }
        };

        // Create the report request
        var reportRequest = new ReportRequest
        {
            ViewId = viewId,
            DateRanges = new[] { dateRange },
            Metrics = { metrics },
            Dimensions = { dimensions }
        };

        var getReportsRequest = new GetReportsRequest
        {
            ReportRequests = new[] { reportRequest }
        };

        // Get the report
        var response = await service.Reports.BatchGet(getReportsRequest).ExecuteAsync();

        // Process and display the report data
        foreach (var report in response.Reports)
        {
            Console.WriteLine("Report Name: " + report.FormattedReportName);
            var headers = report.ColumnHeader;

            // Display header info
            Console.WriteLine("Dimensions: " + string.Join(", ", headers.Dimensions));
            Console.WriteLine("Metrics: " + string.Join(", ", headers.MetricHeader.MetricHeaderEntries));

            // Loop through rows
            foreach (var row in report.Data.Rows)
            {
                var dimensionsValues = row.Dimensions;
                var metricsValues = row.Metrics[0].Values;

                // Display each row
                Console.WriteLine(string.Join(" | ", dimensionsValues) + " => " +
                                  string.Join(", ", metricsValues));
            }
        }
    }
}