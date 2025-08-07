
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string text = "I love this product! It works really well.";

        string apiKey = "YOUR_API_KEY";
        string endpoint = "https://YOUR_ENDPOINT/v2.0/sentiment";

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

        string requestParams = "?showStats=True";
        string requestBody = $"{{\"documents\": [{{\"id\": \"1\", \"text\": \"{text}\"}}]}}";

        HttpResponseMessage response = await client.PostAsync(endpoint + requestParams, new StringContent(requestBody, Encoding.UTF8, "application/json"));

        string responseContent = await response.Content.ReadAsStringAsync();

        Console.WriteLine(responseContent);
    }
}
