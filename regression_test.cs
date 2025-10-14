
using System;
using System.Net;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        // Make a request to the JSON API
        using (WebClient client = new WebClient())
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts/1";
            string json = client.DownloadString(apiUrl);

            // Deserialize the JSON response
            dynamic data = JsonConvert.DeserializeObject(json);

            // Process the data
            Console.WriteLine($"Post Title: {data.title}");
            Console.WriteLine($"Post Body: {data.body}");
        }
    }
}
