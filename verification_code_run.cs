
using System;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set your Text Analytics API endpoint and key here
            string endpoint = "YOUR_TEXT_ANALYTICS_ENDPOINT";
            string key = "YOUR_TEXT_ANALYTICS_KEY";

            // Create a Text Analytics client
            var client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials(key))
            {
                Endpoint = endpoint
            };

            // Input text to analyze
            string text = "I love working on new projects and learning new technologies.";

            // Call the sentiment analysis API
            var result = client.Sentiment(
                new MultiLanguageBatchInput(
                    new List<MultiLanguageInput>()
                    {
                        new MultiLanguageInput("en", "1", text)
                    }));

            // Display the sentiment score
            foreach (var document in result.Documents)
            {
                Console.WriteLine($"Sentiment score for text: {document.Score}");
            }
        }
    }
}
