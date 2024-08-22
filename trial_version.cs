
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string text = "I love programming!";

        string apiKey = "YOUR_API_KEY_HERE";
        string endpoint = "https://YOUR_ENDPOINT_HERE";

        string requestBody = "{ \"documents\": [ { \"language\": \"en\", \"id\": \"1\", \"text\": \"" + text + "\" } ] }";

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);
            var response = await client.PostAsync(endpoint, new StringContent(requestBody, Encoding.UTF8, "application/json"));
            var responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine("Response: " + responseBody);
            Console.WriteLine();

            // Parse and extract sentiment score
            if (response.IsSuccessStatusCode)
            {
                int start = responseBody.IndexOf("\"score\":") + 8;
                int end = responseBody.IndexOf(",", start);
                string scoreString = responseBody.Substring(start, end - start);
                double score = double.Parse(scoreString);
                
                Console.WriteLine("Sentiment score: " + score);
                Console.WriteLine("Sentiment: " + (score > 0.5 ? "Positive" : (score < 0.5 ? "Negative" : "Neutral")));
            }
            else
            {
                Console.WriteLine("Error: " + responseBody);
            }
        }
    }
}
