
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysis
{
    class Program
    {
        static string apiKey = "YOUR_API_KEY"; // Replace with your Text Analytics API key
        static string endpoint = "https://YOUR_ENDPOINT.cognitiveservices.azure.com/";

        static async Task Main(string[] args)
        {
            string text = "I love this product! It is amazing.";

            var sentiment = await GetSentiment(text);

            Console.WriteLine($"Sentiment score: {sentiment}");
        }

        static async Task<double> GetSentiment(string text)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var url = $"{endpoint}/text/analytics/v3.0/sentiment";

            var requestBody = $"{{\"documents\": [{{\"id\": \"1\", \"text\": \"{text}\"}}]}}";

            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var sentimentResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(responseContent);
                double sentiment = sentimentResponse.documents[0].sentiment;
                return sentiment;
            }
            else
            {
                Console.WriteLine($"Error: {responseContent}");
                return 0.0;
            }
        }
    }
}
