
using System;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

class Program
{
    static async Task Main()
    {
        // Set up the Text Analytics client
        string apiKey = "YOUR_API_KEY";
        TextAnalyticsClient client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials(apiKey))
        {
            Endpoint = "YOUR_ENDPOINT"
        };

        // Prompt user to enter text to analyze
        Console.Write("Enter text to analyze: ");
        string text = Console.ReadLine();

        // Perform sentiment analysis on the input text
        SentimentBatchResult result = await client.SentimentAsync(new MultiLanguageBatchInput(
            new List<MultiLanguageInput>()
            {
                new MultiLanguageInput("en", "0", text)
            }));

        // Display the sentiment score
        double score = result.Documents[0].Score;
        Console.WriteLine($"Sentiment score: {score}");

        // Determine sentiment label based on score
        string label = score < 0.4 ? "Negative" : score > 0.6 ? "Positive" : "Neutral";
        Console.WriteLine($"Sentiment label: {label}");
    }
}
