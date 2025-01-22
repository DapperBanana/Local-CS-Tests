
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
            string text = "I love this movie! It's so amazing.";

            string apiKey = "YOUR_API_KEY";
            string endpoint = "https://YOUR_ENDPOINT.cognitiveservices.azure.com/text/analytics/v3.0/sentiment";
            
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var requestBody = new
            {
                documents = new[]
                {
                    new
                    {
                        id = "1",
                        text = text
                    }
                }
            };
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
            
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            var response = await client.PostAsync(endpoint, content);
            var responseContent = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseContent);
        }
    }
}
