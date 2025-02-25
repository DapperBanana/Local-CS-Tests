
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysis
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string text = "This is a sample text to analyze sentiment.";
            string apiKey = "YOUR_AZURE_TEXT_ANALYTICS_API_KEY";
            string endpoint = "https://YOUR_AZURE_TEXT_ANALYTICS_ENDPOINT";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            string requestBody = $"{{\"documents\":[{{\"id\":\"1\",\"text\":\"{text}\"}}]}";
            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(endpoint, content);
            string responseContent = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseContent);
        }
    }
}
