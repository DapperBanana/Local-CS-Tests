
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main()
    {
        using var client = new HttpClient();
        
        var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
        
        if (response.IsSuccessStatusCode)
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            var posts = JsonConvert.DeserializeObject<Post[]>(jsonString);
            
            foreach (var post in posts)
            {
                Console.WriteLine($"Title: {post.Title}");
                Console.WriteLine($"Body: {post.Body}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine($"Failed to fetch data. Status code: {response.StatusCode}");
        }
    }
}

public class Post
{
    [JsonProperty("userId")]
    public int UserId { get; set; }
    
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [JsonProperty("title")]
    public string Title { get; set; }
    
    [JsonProperty("body")]
    public string Body { get; set; }
}
