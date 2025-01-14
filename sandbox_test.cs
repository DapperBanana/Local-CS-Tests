
using System;
using System.Collections.Generic;

class Post
{
    public string Text { get; set; }
    public string Author { get; set; }

    public Post(string text, string author)
    {
        Text = text;
        Author = author;
    }

    public void Display()
    {
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Post: {Text}");
        Console.WriteLine();
    }
}

class SocialMediaPlatform
{
    private List<Post> posts;

    public SocialMediaPlatform()
    {
        posts = new List<Post>();
    }

    public void AddPost(string text, string author)
    {
        Post post = new Post(text, author);
        posts.Add(post);
    }

    public void DisplayPosts()
    {
        foreach (Post post in posts)
        {
            post.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMediaPlatform platform = new SocialMediaPlatform();

        while (true)
        {
            Console.WriteLine("1. Add Post");
            Console.WriteLine("2. Display Posts");
            Console.WriteLine("3. Exit");
            Console.WriteLine();

            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                Console.Write("Enter your name: ");
                string author = Console.ReadLine();
                Console.Write("Enter your post: ");
                string text = Console.ReadLine();

                platform.AddPost(text, author);
                Console.WriteLine("Post added successfully!");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                platform.DisplayPosts();
            }
            else if (choice == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
