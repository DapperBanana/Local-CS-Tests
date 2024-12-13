
using System;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace SentimentAnalysis
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var apiKey = "YOUR_API_KEY";
            var endpoint = "YOUR_ENDPOINT";

            var text = "I love programming, it's so much fun!";
            var client = new TextAnalyticsClient(new ApiKeyServiceClientCredentials(apiKey))
            {
                Endpoint = endpoint
            };

            var result = await client.SentimentAsync("en", new MultiLanguageBatchInput(new List<MultiLanguageInput>()
            {
                new MultiLanguageInput("1", "en", text)
            }));

            var score = result.Documents[0].Score;
            Console.WriteLine($"The sentiment score for the text is: {score}");

            if (score < 0.5)
            {
                Console.WriteLine("The sentiment is negative.");
            }
            else
            {
                Console.WriteLine("The sentiment is positive.");
            }
        }
    }
}
