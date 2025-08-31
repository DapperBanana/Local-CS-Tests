
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
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

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/analytics-dotnet-credentials.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            var service = new AnalyticsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            var request = service.Data.Ga.Get("ga:123456789", "2019-01-01", "2019-12-31", "ga:pageviews");
            request.MaxResults = 10;

            var data = request.Execute();

            if (data.Rows != null)
            {
                Console.WriteLine("Top 10 pages by pageviews:");

                foreach (var row in data.Rows)
                {
                    Console.WriteLine(row[0] + ": " + row[1]);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }
    }
}
