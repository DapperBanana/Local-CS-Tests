
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        const string apiKey = "YOUR_TEXT_ANALYTICS_API_KEY";
        string text = "I love this product! It's amazing.";

        string url = "https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/sentiment";
        var requestBody = "{ \"documents\": [ { \"id\": \"1\", \"text\": \"" + text + "\" } ] }";

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var response = await client.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            var responseBody = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Sentiment analysis result: " + responseBody);
            }
            else
            {
                Console.WriteLine("Error: " + responseBody);
            }
        }
    }
}
