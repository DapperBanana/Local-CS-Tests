
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SentimentAnalysis
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string text = "I love coding in C#";

            string apiKey = "YOUR_API_KEY";
            string endpoint = "https://YOUR_ENDPOINT/api/text/analytics/v3.0/sentiment";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var requestBody = JsonConvert.SerializeObject(new
            {
                documents = new[]
                {
                    new { id = "1", text = text }
                }
            });

            var httpContent = new StringContent(requestBody, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(endpoint, httpContent);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                dynamic result = JsonConvert.DeserializeObject(responseContent);
                double sentimentScore = result.documents[0].sentiment;

                if (sentimentScore < 0.4)
                {
                    Console.WriteLine("Negative sentiment");
                }
                else if (sentimentScore > 0.6)
                {
                    Console.WriteLine("Positive sentiment");
                }
                else
                {
                    Console.WriteLine("Neutral sentiment");
                }
            }
            else
            {
                Console.WriteLine("Failed to analyze sentiment");
            }
        }
    }
}
