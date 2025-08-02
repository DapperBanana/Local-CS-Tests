
using System;
using System.Collections.Generic;

class Post
{
    public string Username { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
}

class SocialMediaPlatform
{
    private List<Post> posts = new List<Post>();

    public void CreatePost(string username, string content)
    {
        Post newPost = new Post
        {
            Username = username,
            Content = content,
            Timestamp = DateTime.Now
        };
        posts.Add(newPost);
    }

    public void DisplayPosts()
    {
        foreach (var post in posts)
        {
            Console.WriteLine("Username: " + post.Username);
            Console.WriteLine("Content: " + post.Content);
            Console.WriteLine("Timestamp: " + post.Timestamp);
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMediaPlatform platform = new SocialMediaPlatform();

        platform.CreatePost("Alice", "Hello, this is my first post!");
        platform.CreatePost("Bob", "Just finished a great book, highly recommend!");

        platform.DisplayPosts();
    }
}
