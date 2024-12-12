
using System;
using System.Collections.Generic;

class SocialMediaPlatform
{
    Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

    public void RegisterUser(string username)
    {
        users.Add(username, new List<string>());
    }

    public void PostMessage(string username, string message)
    {
        if (users.ContainsKey(username))
        {
            users[username].Add(message);
            Console.WriteLine("Message posted successfully.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void ViewNewsFeed(string username)
    {
        if (users.ContainsKey(username))
        {
            List<string> newsFeed = new List<string>();
            foreach (var user in users)
            {
                if (user.Key != username)
                {
                    newsFeed.AddRange(user.Value);
                }
            }

            newsFeed.Sort((x, y) => y.CompareTo(x));

            Console.WriteLine("News Feed:");
            foreach (var message in newsFeed)
            {
                Console.WriteLine(message);
            }
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void FollowUser(string follower, string followee)
    {
        if (users.ContainsKey(follower) && users.ContainsKey(followee))
        {
            users[follower].AddRange(users[followee]);
            Console.WriteLine($"{follower} is now following {followee}.");
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
        
        socialMedia.RegisterUser("Alice");
        socialMedia.RegisterUser("Bob");
        socialMedia.RegisterUser("Charlie");

        socialMedia.PostMessage("Alice", "Hello World!");
        socialMedia.PostMessage("Bob", "Good morning everyone!");

        socialMedia.FollowUser("Bob", "Alice");

        socialMedia.PostMessage("Charlie", "Have a great day!");

        socialMedia.ViewNewsFeed("Bob");
    }
}
