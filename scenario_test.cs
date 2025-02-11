
using System;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I love programming!";

            var client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials("<YOUR_TEXT_ANALYTICS_API_KEY>"))
            {
                Endpoint = "https://<YOUR_TEXT_ANALYTICS_REGION>.api.cognitive.microsoft.com/"
            };

            var result = client.Sentiment(text, "en");

            Console.WriteLine($"Sentiment score: {result.Score}");
        }
    }
}
