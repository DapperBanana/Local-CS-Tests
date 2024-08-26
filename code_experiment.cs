
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;

namespace GoogleAnalyticsAPI
{
    class Program
    {
        static string[] Scopes = { AnalyticsService.Scope.AnalyticsReadonly };
        static string ApplicationName = "Google Analytics API C#";

        static void Main(string[] args)
        {
            UserCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets,
                    Scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
            }

            var service = new AnalyticsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            var request = service.Data.Ga.Get("ga:YOUR_VIEW_ID", "2021-01-01", "2021-01-31", "ga:pageviews");
            var response = request.Execute();

            if (response != null && response.Rows != null)
            {
                foreach (var row in response.Rows)
                {
                    Console.WriteLine(row[0] + " - " + row[1]);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }
    }
}
