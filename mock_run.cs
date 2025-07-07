
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string text = "I love programming and writing code!";

        string uri = "https://<your-text-analytics-endpoint>.cognitiveservices.azure.com/text/analytics/v3.0/sentiment";
        string apiKey = "<your-api-key>";

        HttpClient httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

        string requestBody = "{\"documents\": [{\"id\": \"1\", \"language\": \"en\", \"text\": \"" + text + "\"}]}";
        StringContent content = new StringContent(requestBody, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await httpClient.PostAsync(uri, content);
        string responseContent = await response.Content.ReadAsStringAsync();

        Console.WriteLine(responseContent);
    }
}
