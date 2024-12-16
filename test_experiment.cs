
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
        foreach (Post post in posts)
        {
            Console.WriteLine($"\n{post.Username} - {post.Timestamp}");
            Console.WriteLine(post.Content);
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
            Console.WriteLine("\n1. Create a post\n2. View posts\n3. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter your username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter your post: ");
                    string content = Console.ReadLine();
                    socialMedia.CreatePost(username, content);
                    break;
                case 2:
                    socialMedia.DisplayPosts();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
