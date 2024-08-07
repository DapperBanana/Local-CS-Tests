
using System;
using System.Collections.Generic;

class User
{
    public string Username { get; set; }
    public List<string> Posts { get; } = new List<string>();

    public User(string username)
    {
        Username = username;
    }

    public void AddPost(string post)
    {
        Posts.Add(post);
        Console.WriteLine("Post added successfully!");
    }

    public void ViewPosts()
    {
        Console.WriteLine($"Posts by {Username}:");
        foreach (var post in Posts)
        {
            Console.WriteLine(post);
        }
    }
}

class Program
{
    static List<User> users = new List<User>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Create user");
            Console.WriteLine("2. Make a post");
            Console.WriteLine("3. View posts");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateUser();
                    break;
                case 2:
                    MakePost();
                    break;
                case 3:
                    ViewPosts();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateUser()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        User user = new User(username);
        users.Add(user);
        Console.WriteLine("User created successfully!");
    }

    static void MakePost()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        User user = users.Find(u => u.Username == username);

        if (user != null)
        {
            Console.Write("Enter your post: ");
            string post = Console.ReadLine();
            user.AddPost(post);
        }
        else
        {
            Console.WriteLine("User not found. Please try again.");
        }
    }

    static void ViewPosts()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        User user = users.Find(u => u.Username == username);

        if (user != null)
        {
            user.ViewPosts();
        }
        else
        {
            Console.WriteLine("User not found. Please try again.");
        }
    }
}
