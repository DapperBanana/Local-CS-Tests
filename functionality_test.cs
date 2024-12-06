
using System;
using System.Collections.Generic;

class Post
{
    public string Content { get; set; }
    public DateTime PostedAt { get; set; }
    public string Author { get; set; }

    public Post(string content, string author)
    {
        Content = content;
        PostedAt = DateTime.Now;
        Author = author;
    }
}

class SocialMediaPlatform
{
    private List<Post> posts;

    public SocialMediaPlatform()
    {
        posts = new List<Post>();
    }

    public void CreatePost(string content, string author)
    {
        Post newPost = new Post(content, author);
        posts.Add(newPost);
        Console.WriteLine("Post created successfully!");
    }

    public void DisplayPosts()
    {
        foreach (Post post in posts)
        {
            Console.WriteLine($"Author: {post.Author}");
            Console.WriteLine($"Posted at: {post.PostedAt}");
            Console.WriteLine($"Content: {post.Content}\n");
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMediaPlatform platform = new SocialMediaPlatform();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Create post");
            Console.WriteLine("2. Display posts");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter your name: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter post content: ");
                    string content = Console.ReadLine();
                    platform.CreatePost(content, author);
                    break;
                case 2:
                    platform.DisplayPosts();
                    break;
                case 3:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
