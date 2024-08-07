
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

    public void AddPost(string username, string content)
    {
        Post newPost = new Post
        {
            Username = username,
            Content = content,
            Timestamp = DateTime.Now
        };
        posts.Add(newPost);
        Console.WriteLine("Post added successfully!");
    }

    public void DisplayPosts()
    {
        foreach (Post post in posts)
        {
            Console.WriteLine("{0} posted: {1} - {2}", post.Username, post.Content, post.Timestamp);
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
            Console.WriteLine("1. Add a new post");
            Console.WriteLine("2. Display all posts");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter your username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter your post: ");
                    string content = Console.ReadLine();
                    socialMedia.AddPost(username, content);
                    break;
                case 2:
                    socialMedia.DisplayPosts();
                    break;
                case 3:
                    Console.WriteLine("Exiting program...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
