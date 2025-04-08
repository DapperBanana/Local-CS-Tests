
using System;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string apiKey = "YOUR_TEXT_ANALYTICS_API_KEY";
            string endpoint = "https://YOUR_TEXT_ANALYTICS_ENDPOINT.cognitiveservices.azure.com/";

            var client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials(apiKey)) { Endpoint = endpoint };

            Console.WriteLine("Enter the text to analyze:");
            string text = Console.ReadLine();

            var result = client.Sentiment(text);

            Console.WriteLine($"Sentiment Score: {result.Score:0.00}");
            Console.WriteLine($"Sentiment Label: {result.Sentiment.ToString()}");
        }
    }
}
