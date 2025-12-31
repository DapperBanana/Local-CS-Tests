using System;
using System.Collections.Generic;

namespace TextBasedSocialMedia
{
    class Program
    {
        static List<string> posts = new List<string>();
        static string currentUser = "Guest";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Text-Based Social Media Platform!");

            Console.Write("Enter your username: ");
            currentUser = Console.ReadLine();
            Console.WriteLine($"Hello, {currentUser}!");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Create a new post");
                Console.WriteLine("2. View all posts");
                Console.WriteLine("3. Switch user");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CreatePost();
                        break;
                    case "2":
                        ViewPosts();
                        break;
                    case "3":
                        SwitchUser();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void CreatePost()
        {
            Console.WriteLine($"What's on your mind, {currentUser}?");
            string postContent = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(postContent))
            {
                string post = $"{currentUser}: {postContent}";
                posts.Add(post);
                Console.WriteLine("Post added!");
            }
            else
            {
                Console.WriteLine("Empty post. Nothing was added.");
            }
        }

        static void ViewPosts()
        {
            if (posts.Count == 0)
            {
                Console.WriteLine("No posts to display.");
            }
            else
            {
                Console.WriteLine("\n--- All Posts ---");
                foreach (var post in posts)
                {
                    Console.WriteLine(post);
                }
                Console.WriteLine("--- End of Posts ---");
            }
        }

        static void SwitchUser()
        {
            Console.Write("Enter new username: ");
            string newUser = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newUser))
            {
                currentUser = newUser;
                Console.WriteLine($"Switched to user: {currentUser}");
            }
            else
            {
                Console.WriteLine("Invalid username. User not changed.");
            }
        }
    }
}