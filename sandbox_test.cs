
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiKey = "YOUR_API_KEY";
        string text = "I love this product! It's amazing.";

        string endpoint = "https://YOUR_RESOURCE_NAME.cognitiveservices.azure.com/text/analytics/v3.0/sentiment";
        
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

        string requestBody = "{\"documents\": [{\"id\": \"1\", \"language\": \"en\", \"text\": \"" + text + "\"}]}";
        
        HttpResponseMessage response = await client.PostAsync(endpoint, new StringContent(requestBody, Encoding.UTF8, "application/json"));
        
        string responseContent = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseContent);
    }
}
