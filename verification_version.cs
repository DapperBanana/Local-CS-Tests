
using System;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiKey = "YOUR_API_KEY";
            string endpoint = "YOUR_ENDPOINT";

            var credentials = new ApiKeyServiceClientCredentials(apiKey);
            var textAnalyticsClient = new TextAnalyticsClient(credentials)
            {
                Endpoint = endpoint
            };

            string text = "The weather today is beautiful and I'm feeling happy.";

            var result = textAnalyticsClient.Sentiment(text);

            Console.WriteLine($"Sentiment score: {result.Score:0.00}");
            Console.WriteLine($"Sentiment: {result.Sentiment}");
        }
    }
}
