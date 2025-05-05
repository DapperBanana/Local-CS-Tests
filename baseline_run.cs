
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System;

class Program
{
    static void Main()
    {
        // Authenticate to the Google Analytics API using a service account
        var credential = GoogleCredential.FromFile("path/to/credentials.json")
            .CreateScoped(AnalyticsService.Scope.AnalyticsReadonly);
        
        var service = new AnalyticsService(new BaseClientService.Initializer
        {
            HttpClientInitializer = credential,
            ApplicationName = "Analytics API"
        });

        // Get data from the Google Analytics API
        var request = service.Data.Ga.Get("ga:12345678", "7daysAgo", "today", "ga:users,ga:sessions");
        request.Dimensions = "ga:date";
        var data = request.Execute();

        // Display the data
        if (data.Rows != null)
        {
            foreach (var row in data.Rows)
            {
                Console.WriteLine($"{row[0]}: Users={row[1]}, Sessions={row[2]}");
            }
        }
        else
        {
            Console.WriteLine("No data found.");
        }
    }
}
