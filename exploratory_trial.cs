
using System;
using System.Collections.Generic;

namespace BasicSocialMediaPlatform
{
    class Program
    {
        static List<string> posts = new List<string>();

        static void Main(string[] args)
        {
            bool runApp = true;

            while (runApp)
            {
                Console.WriteLine("Welcome to Basic Social Media Platform!");
                Console.WriteLine("1. View Posts");
                Console.WriteLine("2. Create Post");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewPosts();
                        break;
                    case "2":
                        CreatePost();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        runApp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ViewPosts()
        {
            Console.WriteLine("Recent Posts:");
            foreach (var post in posts)
            {
                Console.WriteLine(post);
            }
        }

        static void CreatePost()
        {
            Console.WriteLine("Enter your post:");
            string post = Console.ReadLine();
            posts.Add(post);
            Console.WriteLine("Post created successfully!");
        }
    }
}
