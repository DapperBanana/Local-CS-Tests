
using System;
using System.Collections.Generic;

namespace SocialMediaSimulator
{
    class Program
    {
        static List<string> posts = new List<string>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the Social Media Simulator!");
                Console.WriteLine("1. View Posts");
                Console.WriteLine("2. Add Post");
                Console.WriteLine("3. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ViewPosts();
                        break;
                    case 2:
                        AddPost();
                        break;
                    case 3:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ViewPosts()
        {
            Console.WriteLine("Posts:");
            foreach (string post in posts)
            {
                Console.WriteLine(post);
            }
        }

        static void AddPost()
        {
            Console.Write("Enter your post: ");
            string post = Console.ReadLine();
            posts.Add(post);
            Console.WriteLine("Post added successfully!");
        }
    }
}
