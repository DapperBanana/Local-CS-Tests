
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new HttpClient();

        string url = "https://jsonplaceholder.typicode.com/posts";
        HttpResponseMessage response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            var posts = JsonConvert.DeserializeObject<dynamic[]>(json);

            foreach (var post in posts)
            {
                Console.WriteLine($"Post ID: {post.id}");
                Console.WriteLine($"Title: {post.title}");
                Console.WriteLine($"Body: {post.body}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine($"Failed to fetch data. Status code: {response.StatusCode}");
        }
    }
}
