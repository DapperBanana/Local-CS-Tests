
using System;
using System.Collections.Generic;

class Post
{
    public string Username { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }

    public Post(string username, string content)
    {
        Username = username;
        Content = content;
        Timestamp = DateTime.Now;
    }

    public override string ToString()
    {
        return $"@{Username} - {Content} ({Timestamp})";
    }
}

class SocialMediaPlatform
{
    private List<Post> posts = new List<Post>();

    public void AddPost(string username, string content)
    {
        Post post = new Post(username, content);
        posts.Add(post);
        Console.WriteLine($"New post created by @{username}");
    }

    public void DisplayPosts()
    {
        foreach (Post post in posts)
        {
            Console.WriteLine(post);
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMediaPlatform socialMedia = new SocialMediaPlatform();

        socialMedia.AddPost("john_doe", "Hello everyone!");
        socialMedia.AddPost("jane_smith", "Just had a great day!");

        Console.WriteLine("\nPosts:");
        socialMedia.DisplayPosts();
    }
}
