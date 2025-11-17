
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string text = "I really love this product, it works great!";
        string apiKey = "YOUR_AZURE_API_KEY";
        string endpoint = "https://YOUR_AZURE_REGION.api.cognitive.microsoft.com/text/analytics/v3.0/sentiment";

        var input = new
        {
            documents = new[]
            {
                new { id = 1, text = text }
            }
        };

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(endpoint),
                Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            Console.WriteLine(content);
        }
    }
}
