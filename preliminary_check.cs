
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string text = "I love this product! It has exceeded my expectations.";

        string apiKey = "YOUR_API_KEY";
        string endpoint = "https://YOUR_ENDPOINT/text/analytics/v3.0/sentiment";

        GetSentiment(text, apiKey, endpoint).Wait();
    }

    static async Task GetSentiment(string text, string apiKey, string endpoint)
    {
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(endpoint),
            Content = new StringContent($"{{ \"documents\": [{{ \"id\": \"1\", \"text\": \"{text}\" }}] }}", Encoding.UTF8, "application/json")
        };

        var response = await httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            string responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
        }
        else
        {
            Console.WriteLine($"Failed to analyze sentiment. StatusCode: {response.StatusCode}");
        }
    }
}
