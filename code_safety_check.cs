
using System;
using System.IO;
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace GoogleAnalyticsAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] scopes = { AnalyticsService.Scope.Analytics };

            var clientId = "YOUR_CLIENT_ID";
            var clientSecret = "YOUR_CLIENT_SECRET";

            UserCredential credential;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), ".credentials/analytics-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    System.Threading.CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            var service = new AnalyticsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Google Analytics API sample",
            });

            var accountId = "YOUR_ACCOUNT_ID";
            var webPropertyId = "YOUR_WEB_PROPERTY_ID";
            var profileId = "YOUR_PROFILE_ID";

            var request = service.Data.Ga.Get(accountId, webPropertyId, profileId, "ga:users");

            var result = request.Execute();

            Console.WriteLine($"Total number of users: {result.TotalResults}");
        }
    }
}
