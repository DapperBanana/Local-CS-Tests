
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string text = "I am happy today!";
        string apiKey = "YOUR_TEXT_ANALYTICS_API_KEY"; // Replace this with your API key

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var uri = "https://westus.api.cognitive.microsoft.com/text/analytics/v3.0-preview.1/sentiment";

            string requestBody = "{\"documents\":[{\"id\":\"1\",\"language\":\"en\",\"text\":\"" + text + "\"}]}";
            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(uri, content);
            var responseContent = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseContent);
        }
    }
}
