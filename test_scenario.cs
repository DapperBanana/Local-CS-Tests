
using System;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

class Program
{
    static void Main()
    {
        const string apiKey = "YOUR_API_KEY";
        const string endpoint = "YOUR_ENDPOINT";

        var credentials = new ApiKeyServiceClientCredentials(apiKey);
        var client = new TextAnalyticsClient(credentials)
        {
            Endpoint = endpoint
        };

        string text = "I love this app! It's amazing.";

        Console.WriteLine($"Analyzing sentiment for: {text}");

        var result = client.Sentiment(text);

        Console.WriteLine($"Sentiment score: {result.Score:0.00}");
        Console.WriteLine($"Sentiment label: {result.Sentiment}");

        if (result.Sentences != null)
        {
            foreach (var sentence in result.Sentences)
            {
                Console.WriteLine($"Sentence ({sentence.Offset}, {sentence.Length}): {sentence.Sentiment}");
            }
        }
    }
}
