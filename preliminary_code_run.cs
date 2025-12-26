using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        string inputText = "I love this product! It works fantastic and exceeds expectations.";
        double sentimentScore = await GetSentimentScoreAsync(inputText);
        Console.WriteLine($"Sentiment score: {sentimentScore}");
    }

    static async Task<double> GetSentimentScoreAsync(string text)
    {
        // Replace with your actual Text Analytics subscription key and endpoint
        string subscriptionKey = "YOUR_SUBSCRIPTION_KEY";
        string endpoint = "https://YOUR_REGION.api.cognitive.microsoft.com";

        string sentimentApiUrl = $"{endpoint}/text/analytics/v3.1/sentiment";

        var requestBody = new
        {
            documents = new[]
            {
                new { id = "1", language = "en", text = text }
            }
        };

        string jsonBody = JsonConvert.SerializeObject(requestBody);

        using (var httpClient = new HttpClient())
        {
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(sentimentApiUrl, content);
            string responseContent = await response.Content.ReadAsStringAsync();

            dynamic result = JsonConvert.DeserializeObject(responseContent);
            double sentimentScore = result.documents[0].confidenceScores.positive -
                                    result.documents[0].confidenceScores.negative;
            return sentimentScore;
        }
    }
}