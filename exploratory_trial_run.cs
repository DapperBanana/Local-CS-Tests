
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

class Program
{
    static async Task Main()
    {
        string apiUrl = "https://jsonplaceholder.typicode.com/posts"; // Example JSON API URL

        using HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(apiUrl);
        
        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            
            var posts = JsonSerializer.Deserialize<Post[]>(responseBody);

            foreach (var post in posts)
            {
                Console.WriteLine($"Post Id: {post.Id}\nTitle: {post.Title}\nBody: {post.Body}\n");
            }
        }
        else
        {
            Console.WriteLine($"Failed to retrieve data. Status code: {response.StatusCode}");
        }
    }
}

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}
