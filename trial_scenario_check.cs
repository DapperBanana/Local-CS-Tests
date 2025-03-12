
using System;
using System.Net.Http;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        string apiUrl = "https://jsonplaceholder.typicode.com/posts/1"; // Example JSON API URL
        
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject(json);
                
                Console.WriteLine($"Title: {data.title}");
                Console.WriteLine($"Body: {data.body}");
            }
            else
            {
                Console.WriteLine($"Failed to retrieve data. StatusCode: {response.StatusCode}");
            }
        }
    }
}
