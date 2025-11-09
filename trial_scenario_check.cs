
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string text = "I love programming!";
        string apiKey = "your-api-key"; // Replace with your API key from Azure Text Analytics

        string endpoint = "https://your-text-analytics-endpoint.cognitiveservices.azure.com/text/analytics/v3.0/sentiment";
        string json = $"{{\"documents\": [{{\"id\": \"1\", \"text\": \"{text}\"}}]}}";

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(endpoint, content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error: " + response.ReasonPhrase);
            }
        }
    }
}
