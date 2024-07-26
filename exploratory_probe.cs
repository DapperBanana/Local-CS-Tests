
using System;
using System.Collections.Generic;

class Post
{
    public string Username { get; set; }
    public string Content { get; set; }

    public Post(string username, string content)
    {
        Username = username;
        Content = content;
    }
}

class Program
{
    static List<Post> posts = new List<Post>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Create a new post");
            Console.WriteLine("2. View all posts");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreatePost();
                    break;
                case 2:
                    ViewPosts();
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

    static void CreatePost()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        Console.Write("Enter your post: ");
        string content = Console.ReadLine();

        posts.Add(new Post(username, content));

        Console.WriteLine("Post created successfully!");
    }

    static void ViewPosts()
    {
        Console.WriteLine("All posts:");

        foreach (Post post in posts)
        {
            Console.WriteLine($"{post.Username}: {post.Content}");
        }
    }
}
