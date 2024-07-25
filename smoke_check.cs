
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Load the credentials JSON key file
        GoogleCredential credential;
        using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
        {
            credential = GoogleCredential.FromStream(stream)
                .CreateScoped(new[] { AnalyticsService.Scope.Analytics });
        }

        // Create an Analytics service object
        var service = new AnalyticsService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential
        });

        // Query the Google Analytics API for page views
        DataResource.GaResource.GetRequest request = service.Data.Ga.Get("ga:YOUR_VIEW_ID", "30daysAgo", "today", "ga:pageviews");
        GaData data = request.Execute();

        // Print the page views
        foreach (var row in data.Rows)
        {
            Console.WriteLine($"Page: {row[0]}, Page Views: {row[1]}");
        }
    }
}
