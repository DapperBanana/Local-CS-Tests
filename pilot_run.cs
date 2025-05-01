
using System;
using System.Collections.Generic;

class Post
{
    public string Content { get; set; }
}

class SocialMediaPlatform
{
    private List<Post> posts;

    public SocialMediaPlatform()
    {
        posts = new List<Post>();
    }

    public void CreatePost(string content)
    {
        posts.Add(new Post { Content = content });
    }

    public void DisplayPosts()
    {
        foreach (Post post in posts)
        {
            Console.WriteLine(post.Content);
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMediaPlatform socialMedia = new SocialMediaPlatform();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("1. Create Post\n2. View Posts\n3. Exit");
            Console.Write("Select an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter post content: ");
                    string content = Console.ReadLine();
                    socialMedia.CreatePost(content);
                    break;
                case 2:
                    Console.WriteLine("Posts:");
                    socialMedia.DisplayPosts();
                    break;
                case 3:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
