
using System;
using System.Collections.Generic;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I love this weather, it's so nice!";
            string endpoint = "YOUR_ENDPOINT";
            string key = "YOUR_KEY";

            var client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials(key))
            {
                Endpoint = endpoint
            };

            var inputDocuments = new MultiLanguageBatchInput(
                new List<MultiLanguageInput>()
                {
                    new MultiLanguageInput("en", "1", text)
                });

            var result = client.Sentiment(inputDocuments);

            foreach (var document in result.Documents)
            {
                Console.WriteLine($"Sentiment score: {document.Score}");
            }

            Console.ReadLine();
        }
    }
}
