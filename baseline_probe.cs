
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string viewId = "YOUR_VIEW_ID";
        string keyFilePath = "YOUR_KEY_FILE_PATH.json";

        GoogleCredential credential;
        using (var stream = new System.IO.FileStream(keyFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
        {
            credential = GoogleCredential.FromStream(stream)
                .CreateScoped(AnalyticsReportingService.Scope.AnalyticsReadonly);
        }

        var service = new AnalyticsService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential
        });

        var request = service.Data.Ga.Get("ga:" + viewId, "30daysAgo", "today", "ga:users");

        var response = await request.ExecuteAsync();

        foreach (var row in response.Rows)
        {
            Console.WriteLine($"Users: {row[0]}");
        }
    }
}
