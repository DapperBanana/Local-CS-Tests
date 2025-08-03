
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
            string text = "I love programming!";

            string apiKey = "YOUR_API_KEY";
            string endpoint = "https://YOUR_ENDPOINT.cognitiveservices.azure.com/text/analytics/v3.0/sentiment";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            string requestBody = $"{{ \"documents\": [{{ \"language\": \"en\", \"id\": \"1\", \"text\": \"{text}\" }}] }}";
            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(endpoint, content);
            string responseContent = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseContent);
        }
    }
}
