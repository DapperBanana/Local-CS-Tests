using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Enter the text to analyze:");
        string inputText = Console.ReadLine();

        var sentimentScore = await GetSentimentScoreAsync(inputText);

        Console.WriteLine($"Sentiment score: {sentimentScore}");
        if (sentimentScore > 0.5)
        {
            Console.WriteLine("Overall sentiment: Positive");
        }
        else if (sentimentScore < -0.5)
        {
            Console.WriteLine("Overall sentiment: Negative");
        }
        else
        {
            Console.WriteLine("Overall sentiment: Neutral");
        }
    }

    static async Task<double> GetSentimentScoreAsync(string text)
    {
        // Replace with your actual Azure Text Analytics endpoint and key
        string endpoint = "https://<your-region>.api.cognitive.microsoft.com/";
        string apiKey = "<your-api-key>";

        string uri = $"{endpoint}text/analytics/v3.0/sentiment";

        var documents = new
        {
            documents = new[] {
                new { language = "en", id = "1", text = text }
            }
        };

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);
            var content = new StringContent(JsonConvert.SerializeObject(documents), System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(uri, content);

            string resultString = await response.Content.ReadAsStringAsync();

            dynamic result = JsonConvert.DeserializeObject(resultString);
            if (result.documents.Count > 0)
            {
                double sentimentScore = result.documents[0].confidenceScores.positive 
                                        - result.documents[0].confidenceScores.negative;
                return sentimentScore;
            }
            else
            {
                return 0.0;
            }
        }
    }
}