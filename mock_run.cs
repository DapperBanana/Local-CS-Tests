using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json; // You'll need to install Newtonsoft.Json via NuGet

namespace RestApiExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // URL of the REST API endpoint
            string apiUrl = "https://api.example.com/data";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Send a GET request to the API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    response.EnsureSuccessStatusCode();

                    // Read the response content as a string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON response into a dynamic object
                    var data = JsonConvert.DeserializeObject(responseBody);

                    // Print the results
                    Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
    }
}