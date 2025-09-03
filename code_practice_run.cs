
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
            string text = "I love this product! It's amazing.";

            string apiKey = "YOUR_TEXT_ANALYTICS_API_KEY_HERE";
            string endpoint = "https://YOUR_TEXT_ANALYTICS_ENDPOINT_HERE";
            
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var inputDocuments = new
            {
                documents = new[]
                {
                    new { id = "1", language = "en", text = text }
                }
            };

            var requestBody = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(inputDocuments), Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"{endpoint}/text/analytics/v3.0/sentiment", requestBody);
            var responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
        }
    }
}
