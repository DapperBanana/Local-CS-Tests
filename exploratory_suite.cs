
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string text = "I love programming and coding is my passion!";
        string apiKey = "YOUR_TEXT_ANALYTICS_API_KEY";
        string endpoint = "https://YOUR_TEXT_ANALYTICS_ENDPOINT/text/analytics/v3.2-preview.1/sentiment";

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);
            client.BaseAddress = new Uri(endpoint);

            var requestData = new { documents = new[] { new { id = "1", text = text } } };
            var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(endpoint, requestContent);
            var responseContent = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseContent);
        }
    }
}
