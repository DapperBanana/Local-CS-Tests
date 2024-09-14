
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        // The URL of the JSON API
        string url = "https://jsonplaceholder.typicode.com/posts/1";

        // Create an instance of HttpClient
        HttpClient client = new HttpClient();

        // Send a GET request to the API and get the response
        HttpResponseMessage response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            // Read the response as a string
            string json = await response.Content.ReadAsStringAsync();

            // Deserialize the JSON string to a dynamic object
            dynamic data = JsonConvert.DeserializeObject(json);

            // Access and process the data from the API
            Console.WriteLine($"Title: {data.title}");
            Console.WriteLine($"Body: {data.body}");
        }
        else
        {
            Console.WriteLine($"Failed to retrieve data. Status code: {response.StatusCode}");
        }

        // Dispose of the HttpClient
        client.Dispose();
    }
}
