using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var apiUrl = "https://jsonplaceholder.typicode.com/posts"; // Replace with your REST API URL

        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send GET request to the API
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                // Read response as string
                string responseBody = await response.Content.ReadAsStringAsync();

                // Print the results
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
    }
}