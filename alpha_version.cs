
using System;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

class Program
{
    static void Main()
    {
        string text = "I love coding";
        string apiKey = "YOUR_TEXT_ANALYTICS_API_KEY";

        var client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials(apiKey))
        {
            Endpoint = "https://YOUR_TEXT_ANALYTICS_ENDPOINT/"
        };

        var inputDocuments = new MultiLanguageBatchInput(
            new List<MultiLanguageInput>
            {
                new MultiLanguageInput("en", "1", text)
            });

        var result = client.Sentiment(
            new MultiLanguageBatchInput(
                new List<MultiLanguageInput>
                {
                    new MultiLanguageInput("en", "1", text)
                }));

        double score = result.Documents[0].Score;

        Console.WriteLine($"Sentiment Score: {score}");

        if(score < 0.5)
        {
            Console.WriteLine("Negative sentiment detected");
        }
        else
        {
            Console.WriteLine("Positive sentiment detected");
        }
    }
}
