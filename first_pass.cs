
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main()
    {
        using (var client = new HttpClient())
        {
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var post = JsonConvert.DeserializeObject<Post>(jsonString);
                Console.WriteLine($"Post ID: {post.Id}");
                Console.WriteLine($"User ID: {post.UserId}");
                Console.WriteLine($"Title: {post.Title}");
                Console.WriteLine($"Body: {post.Body}");
            }
            else
            {
                Console.WriteLine("Failed to retrieve data from API.");
            }
        }
    }

    public class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
