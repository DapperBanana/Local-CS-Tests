
using System;
using System.Collections.Generic;

class Post
{
    public string Username { get; set; }
    public string Content { get; set; }
    public DateTime TimeStamp { get; set; }

    public Post(string username, string content)
    {
        Username = username;
        Content = content;
        TimeStamp = DateTime.Now;
    }
}

class SocialMediaPlatform
{
    private List<Post> posts = new List<Post>();

    public void AddPost(string username, string content)
    {
        posts.Add(new Post(username, content));
    }

    public void DisplayPosts()
    {
        foreach (var post in posts)
        {
            Console.WriteLine($"Username: {post.Username}");
            Console.WriteLine($"Content: {post.Content}");
            Console.WriteLine($"Time: {post.TimeStamp}");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMediaPlatform socialMedia = new SocialMediaPlatform();

        while (true)
        {
            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter your post: ");
            string content = Console.ReadLine();

            socialMedia.AddPost(username, content);

            Console.WriteLine("Do you want to add another post? (Y/N)");
            string input = Console.ReadLine();

            if (input.ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("\n--- Showing Posts ---\n");
        socialMedia.DisplayPosts();
    }
}
