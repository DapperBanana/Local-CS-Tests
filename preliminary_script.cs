
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var text = "I love this product! It works great and the customer service is top-notch.";

        string apiKey = "YOUR_API_KEY";
        string endpoint = "https://YOUR_COGNITIVE_SERVICES_ENDPOINT.cognitiveservices.azure.com/text/analytics/v3.0/sentiment";

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

        string requestBody = $"{{ \"documents\": [{{ \"id\": \"1\", \"text\": \"{text}\" }}] }}";

        HttpResponseMessage response = await client.PostAsync(endpoint, new StringContent(requestBody, Encoding.UTF8, "application/json"));
        string jsonResponse = await response.Content.ReadAsStringAsync();

        Console.WriteLine(jsonResponse);
    }
}
