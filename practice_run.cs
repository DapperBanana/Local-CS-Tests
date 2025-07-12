
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] scopes = { AnalyticsService.Scope.AnalyticsReadonly };

        using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
        {
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                scopes,
                "user",
                System.Threading.CancellationToken.None).Result;

            var service = new AnalyticsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential
            });

            GetWebsiteData(service);
        }
    }

    static void GetWebsiteData(AnalyticsService service)
    {
        string profileId = "YOUR_PROFILE_ID";
        DateTime startDate = new DateTime(2020, 1, 1);
        DateTime endDate = new DateTime(2020, 1, 31);
        string metrics = "ga:sessions";
        string dimensions = "ga:date";

        var request = service.Data.Ga.Get("ga:" + profileId, startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"), metrics);
        request.Dimensions = dimensions;

        GaData data = request.Execute();

        if (data.Rows != null)
        {
            foreach (var row in data.Rows)
            {
                Console.WriteLine("Date: {0}, Sessions: {1}", row[0], row[1]);
            }
        }
        else
        {
            Console.WriteLine("No data found.");
        }
    }
}
