
using System;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string url = "https://jsonplaceholder.typicode.com/posts";
        using (WebClient client = new WebClient())
        {
            string json = client.DownloadString(url);

            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(json);

            foreach (Post post in posts)
            {
                Console.WriteLine($"Post ID: {post.Id}");
                Console.WriteLine($"Title: {post.Title}");
                Console.WriteLine($"Body: {post.Body}");
                Console.WriteLine();
            }
        }
    }
}

class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}
