
using Google.Apis.Analytics.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;

namespace GoogleAnalyticsApiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] scopes = { AnalyticsService.Scope.AnalyticsReadonly };
            string applicationName = "Google Analytics API Demo";

            UserCredential credential;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "credPath";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
            }

            // Create the Analytics service
            var service = new AnalyticsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });

            // Now you can use the service to make requests to the Google Analytics API
            // For example, you could retrieve data from a particular view
        }
    }
}
