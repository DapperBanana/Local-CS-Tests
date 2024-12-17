
using System;
using System.Collections.Generic;

class User
{
    public string Username { get; set; }
    public List<string> Posts { get; set; }

    public User(string username)
    {
        Username = username;
        Posts = new List<string>();
    }
}

class SocialMediaPlatform
{
    private List<User> users;

    public SocialMediaPlatform()
    {
        users = new List<User>();
    }

    public void CreateUser(string username)
    {
        users.Add(new User(username));
    }

    public void CreatePost(string username, string post)
    {
        User user = users.Find(u => u.Username == username);
        if (user != null)
        {
            user.Posts.Add(post);
        }
    }

    public void DisplayPosts(string username)
    {
        User user = users.Find(u => u.Username == username);
        if (user != null)
        {
            foreach (string post in user.Posts)
            {
                Console.WriteLine(post);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMediaPlatform socialMedia = new SocialMediaPlatform();

        socialMedia.CreateUser("Alice");
        socialMedia.CreateUser("Bob");

        socialMedia.CreatePost("Alice", "Hello, this is my first post!");
        socialMedia.CreatePost("Bob", "Nice weather today!");

        Console.WriteLine("Alice's posts:");
        socialMedia.DisplayPosts("Alice");

        Console.WriteLine("\nBob's posts:");
        socialMedia.DisplayPosts("Bob");
    }
}
