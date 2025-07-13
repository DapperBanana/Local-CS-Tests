
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string text = "I love programming!";
        string apiKey = "YOUR_API_KEY";
        string endpoint = "https://your-endpoint.cognitiveservices.azure.com/text/analytics/v3.0/sentiment";

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var requestData = new
            {
                documents = new[]
                {
                    new
                    {
                        id = 1,
                        text = text
                    }
                }
            };

            var requestContent = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(endpoint, requestContent);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent);

                double sentimentScore = result.documents[0].sentiment;

                if (sentimentScore < 0.5)
                {
                    Console.WriteLine("Negative sentiment detected.");
                }
                else
                {
                    Console.WriteLine("Positive sentiment detected.");
                }
            }
            else
            {
                Console.WriteLine("Failed to analyze sentiment.");
                Console.WriteLine(response.ReasonPhrase);
            }
        }
    }
}
