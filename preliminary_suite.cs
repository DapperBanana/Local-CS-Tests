
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main()
    {
        string apiUrl = "https://jsonplaceholder.typicode.com/posts";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                JArray posts = JArray.Parse(json);

                foreach (JObject post in posts)
                {
                    int id = (int)post["id"];
                    string title = (string)post["title"];
                    string body = (string)post["body"];

                    Console.WriteLine($"Post ID: {id}");
                    Console.WriteLine($"Title: {title}");
                    Console.WriteLine($"Body: {body}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Failed to retrieve data from API.");
            }
        }
    }
}
