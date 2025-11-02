
using System;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

class Program
{
    static void Main()
    {
        string text = "I love this product! It's amazing.";
        string apiKey = "YOUR_API_KEY";

        var credentials = new ApiKeyServiceClientCredentials(apiKey);
        var client = new TextAnalyticsClient(credentials)
        {
            Endpoint = "https://westus.api.cognitive.microsoft.com/"
        };

        // Analyze sentiment
        var result = client.Sentiment(text);

        Console.WriteLine($"Sentiment score: {result.Score:0.00}");
    }
}
