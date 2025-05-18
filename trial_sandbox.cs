
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;

namespace GoogleAnalyticsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var credential = GetCredential();
            var service = new AnalyticsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential
            });

            var request = service.Data.Ga.Get("ga:YOUR_VIEW_ID", "7daysAgo", "today", "ga:pageviews");
            var data = request.Execute();

            Console.WriteLine("Pageviews in the last 7 days: " + data.Rows[0][0]);
        }

        private static UserCredential GetCredential()
        {
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/google-analytics-api-dotnet-quickstart.json");

                return GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { AnalyticsService.Scope.AnalyticsReadonly },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
        }
    }
}
