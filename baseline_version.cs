
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;

namespace GoogleAnalyticsAnalyzer
{
    class Program
    {
        static string[] Scopes = { AnalyticsService.Scope.Analytics };
        static string ApplicationName = "Google Analytics Analyzer";

        static void Main(string[] args)
        {
            UserCredential credential;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), ".credentials");
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

            var request = service.Data.Ga.Get("ga:YOUR_VIEW_ID", "30daysAgo", "today", "ga:users");
            var data = request.Execute();

            Console.WriteLine("Total users in the last 30 days: " + data.Rows[0][0]);
        }
    }
}
