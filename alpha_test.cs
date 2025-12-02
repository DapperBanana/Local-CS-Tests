using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace JsonApiReader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string apiUrl = "https://api.example.com/data"; // Replace with your API endpoint

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send GET request to the API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    // Read response content as a string
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON data into a dynamic object
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var data = JsonSerializer.Deserialize<JsonElement>(jsonResponse, options);

                    // Process the JSON data
                    Console.WriteLine("Received Data:");
                    Console.WriteLine(data);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                }
                catch (JsonException e)
                {
                    Console.WriteLine($"JSON parsing error: {e.Message}");
                }
            }
        }
    }
}