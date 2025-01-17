
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] scopes = new[] { AnalyticsService.Scope.Analytics };

        var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
            new ClientSecrets
            {
                ClientId = "YOUR_CLIENT_ID",
                ClientSecret = "YOUR_CLIENT_SECRET"
            },
            scopes,
            "user",
            System.Threading.CancellationToken.None).Result;

        var service = new AnalyticsService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential
        });

        string profileId = "ga:YOUR_PROFILE_ID";
        string startDate = "2022-01-01";
        string endDate = "2022-01-31";
        string metrics = "ga:users";
        string dimensions = "ga:date";

        var request = service.Data.Ga.Get(profileId, startDate, endDate, metrics);
        request.Dimensions = dimensions;

        var response = request.Execute();

        if (response != null && response.Rows != null)
        {
            foreach (var row in response.Rows)
            {
                Console.WriteLine($"Date: {row[0]}, Users: {row[1]}");
            }
        }
        else
        {
            Console.WriteLine("No data found.");
        }
    }
}
