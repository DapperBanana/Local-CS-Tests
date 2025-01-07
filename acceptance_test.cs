
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using System;
using System.Collections.Generic;

namespace SentimentAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiKey = "YOUR_TEXT_ANALYTICS_API_KEY";
            var textAnalyticsClient = new TextAnalyticsClient(new ApiKeyServiceClientCredentials(apiKey))
            {
                Endpoint = "https://TEXT_ANALYTICS_API_ENDPOINT"
            };

            Console.WriteLine("Enter the text to analyze:");
            string inputText = Console.ReadLine();

            var inputDocuments = new MultiLanguageInput(
                new Language("en", "0"),
                new List<MultiLanguageInput>
                {
                    new MultiLanguageInput("1", "en", inputText)
                }
            );

            var result = textAnalyticsClient.Sentiment(
                "1",
                inputDocuments
            );

            double score = result.Documents[0].Score.Value;

            Console.WriteLine($"Sentiment score: {score}");

            if (score < 0.5)
            {
                Console.WriteLine("Negative sentiment");
            }
            else if (score == 0.5)
            {
                Console.WriteLine("Neutral sentiment");
            }
            else
            {
                Console.WriteLine("Positive sentiment");
            }
        }
    }
}
