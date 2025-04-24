
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
       string text = "I love working with Azure Cognitive Services!";
       
       var sentiment = await AnalyzeSentiment(text);
       
       Console.WriteLine($"Sentiment score: {sentiment}");
    }

    static async Task<double> AnalyzeSentiment(string text)
    {
        string apiKey = "YOUR_API_KEY";
        string endpoint = "https://YOUR_SERVICE_NAME.cognitiveservices.azure.com/text/analytics/v3.0/sentiment";

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            var requestBody = new
            {
                documents = new[]
                {
                    new
                    {
                        language = "en",
                        id = 1,
                        text
                    }
                }
            };

            var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(endpoint, content);
            var jsonResponse = await response.Content.ReadAsStringAsync();

            var sentimentResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<SentimentResponse>(jsonResponse);

            return sentimentResponse.documents[0].sentiment.score;
        }
    }
}

public class SentimentResponse
{
    public DocumentSentiment[] documents { get; set; }
}

public class DocumentSentiment
{
    public string id { get; set; }
    public Sentiment sentiment { get; set; }
}

public class Sentiment
{
    public double score { get; set; }
}
