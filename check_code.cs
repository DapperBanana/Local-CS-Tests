
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysis
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string text = "I love coding!";
            string apiKey = "YOUR_TEXT_ANALYTICS_API_KEY";
            string endpoint = "https://YOUR_TEXT_ANALYTICS_ENDPOINT.cognitiveservices.azure.com/text/analytics/v3.0/sentiment";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var requestData = new
            {
                documents = new[]
                {
                    new { id = "1", text = text }
                }
            };

            var requestJson = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);
            var requestContent = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(endpoint, requestContent);
            var responseJson = await response.Content.ReadAsStringAsync();

            var responseObject = Newtonsoft.Json.JsonConvert.DeserializeObject(responseJson);

            double sentimentScore = (double)responseObject["documents"][0]["confidenceScores"]["positive"];
            
            if(sentimentScore > 0.5)
            {
                Console.WriteLine("The text is positive!");
            }
            else if(sentimentScore < 0.5)
            {
                Console.WriteLine("The text is negative :(");
            }
            else
            {
                Console.WriteLine("The text is neutral.");
            }
        }
    }
}
