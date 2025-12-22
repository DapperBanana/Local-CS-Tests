using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Replace with your REST API URL
        string apiUrl = "https://jsonplaceholder.typicode.com/posts";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send GET request to the API
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                // Read the response content as a string
                string responseData = await response.Content.ReadAsStringAsync();

                // Print the results
                Console.WriteLine(responseData);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
    }
}