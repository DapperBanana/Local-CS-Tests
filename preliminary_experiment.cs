using System;
using System.Collections.Generic;

namespace BasicSocialMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialMediaPlatform platform = new SocialMediaPlatform();
            platform.Run();
        }
    }

    class SocialMediaPlatform
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private User currentUser = null;

        public void Run()
        {
            Console.WriteLine("Welcome to the Basic Text-Based Social Media Platform!");
            while (true)
            {
                if (currentUser == null)
                {
                    Console.WriteLine("\nOptions: register | login | exit");
                    Console.Write("Enter command: ");
                    var input = Console.ReadLine().Trim().ToLower();

                    switch (input)
                    {
                        case "register":
                            RegisterUser();
                            break;
                        case "login":
                            LoginUser();
                            break;
                        case "exit":
                            Console.WriteLine("Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid command.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"\nLogged in as: {currentUser.Username}");
                    Console.WriteLine("Options: post | view feed | view my posts | logout");
                    Console.Write("Enter command: ");
                    var input = Console.ReadLine().Trim().ToLower();

                    switch (input)
                    {
                        case "post":
                            CreatePost();
                            break;
                        case "view feed":
                            ViewFeed();
                            break;
                        case "view my posts":
                            ViewMyPosts();
                            break;
                        case "logout":
                            currentUser = null;
                            Console.WriteLine("Logged out.");
                            break;
                        default:
                            Console.WriteLine("Invalid command.");
                            break;
                    }
                }
            }
        }

        private void RegisterUser()
        {
            Console.Write("Enter a username to register: ");
            string username = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Username cannot be empty.");
                return;
            }
            if (users.ContainsKey(username))
            {
                Console.WriteLine("Username already exists.");
                return;
            }
            var user = new User(username);
            users[username] = user;
            Console.WriteLine($"User '{username}' registered successfully.");
        }

        private void LoginUser()
        {
            Console.Write("Enter your username to login: ");
            string username = Console.ReadLine().Trim();
            if (users.ContainsKey(username))
            {
                currentUser = users[username];
                Console.WriteLine($"Logged in as '{username}'.");
            }
            else
            {
                Console.WriteLine("Username not found.");
            }
        }

        private void CreatePost()
        {
            Console.Write("Enter your post content: ");
            string content = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(content))
            {
                Console.WriteLine("Post content cannot be empty.");
                return;
            }
            var post = new Post(currentUser.Username, content, DateTime.Now);
            currentUser.Posts.Add(post);
            Console.WriteLine("Post added successfully.");
        }

        private void ViewFeed()
        {
            Console.WriteLine("\n--- Feed ---");
            List<Post> allPosts = new List<Post>();
            foreach (var user in users.Values)
            {
                allPosts.AddRange(user.Posts);
            }
            allPosts.Sort((p1, p2) => p2.Timestamp.CompareTo(p1.Timestamp));
            if (allPosts.Count == 0)
            {
                Console.WriteLine("No posts to display.");
                return;
            }
            foreach (var post in allPosts)
            {
                Console.WriteLine($"{post.Timestamp} - {post.Username}: {post.Content}");
            }
        }

        private void ViewMyPosts()
        {
            Console.WriteLine("\n--- My Posts ---");
            if (currentUser.Posts.Count == 0)
            {
                Console.WriteLine("You have no posts.");
                return;
            }
            foreach (var post in currentUser.Posts)
            {
                Console.WriteLine($"{post.Timestamp}: {post.Content}");
            }
        }
    }

    class User
    {
        public string Username { get; }
        public List<Post> Posts { get; }

        public User(string username)
        {
            Username = username;
            Posts = new List<Post>();
        }
    }

    class Post
    {
        public string Username { get; }
        public string Content { get; }
        public DateTime Timestamp { get; }

        public Post(string username, string content, DateTime timestamp)
        {
            Username = username;
            Content = content;
            Timestamp = timestamp;
        }
    }
}