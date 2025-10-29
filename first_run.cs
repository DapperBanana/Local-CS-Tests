
using System;
using System.Collections.Generic;

public class User
{
    public string Username { get; set; }
    public List<User> Following { get; set; }
    public List<string> Posts { get; set; }

    public User(string username)
    {
        Username = username;
        Following = new List<User>();
        Posts = new List<string>();
    }
}

public class SocialMediaPlatform
{
    public List<User> Users { get; set; }

    public SocialMediaPlatform()
    {
        Users = new List<User>();
    }

    public void CreateUser(string username)
    {
        Users.Add(new User(username));
    }

    public void FollowUser(string followerUsername, string followeeUsername)
    {
        User follower = Users.Find(user => user.Username == followerUsername);
        User followee = Users.Find(user => user.Username == followeeUsername);

        if (follower != null && followee != null)
        {
            follower.Following.Add(followee);
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void PostMessage(string username, string message)
    {
        User user = Users.Find(u => u.Username == username);

        if (user != null)
        {
            user.Posts.Add(message);
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void ViewTimeline(string username)
    {
        User user = Users.Find(u => u.Username == username);

        if (user != null)
        {
            Console.WriteLine($"Timeline for {username}:");
            foreach (string post in user.Posts)
            {
                Console.WriteLine(post);
            }

            foreach (User followingUser in user.Following)
            {
                Console.WriteLine($"\nPosts from {followingUser.Username}:");
                foreach (string post in followingUser.Posts)
                {
                    Console.WriteLine(post);
                }
            }
        }
        else
        {
            Console.WriteLine("User not found.");
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
        socialMedia.CreateUser("Charlie");

        socialMedia.FollowUser("Alice", "Bob");
        socialMedia.FollowUser("Alice", "Charlie");

        socialMedia.PostMessage("Alice", "Hello, world!");
        socialMedia.PostMessage("Bob", "Good morning!");
        socialMedia.PostMessage("Charlie", "How is everyone doing?");

        socialMedia.ViewTimeline("Alice");
        socialMedia.ViewTimeline("Bob");
        socialMedia.ViewTimeline("Charlie");
    }
}
