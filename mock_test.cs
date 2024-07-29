
using System;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I love coding in C#!";

            ITextAnalyticsClient client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials("<YOUR_API_KEY>"))
            {
                Endpoint = "https://<YOUR_API_REGION>.api.cognitive.microsoft.com/"
            };

            var result = client.Sentiment(text);

            Console.WriteLine($"Sentiment Score: {result.Score:0.00}");
            Console.WriteLine($"Sentiment: {result.Sentiment}");

            Console.ReadLine();
        }
    }
}
