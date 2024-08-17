
using System;
using System.Collections.Generic;

namespace SocialMediaPlatform
{
    class Program
    {
        static List<string> posts = new List<string>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Create a post\n2. View posts\n3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreatePost();
                        break;
                    case 2:
                        ViewPosts();
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

        static void CreatePost()
        {
            Console.Write("Enter your post: ");
            string post = Console.ReadLine();
            posts.Add(post);
            Console.WriteLine("Post created successfully!");
        }

        static void ViewPosts()
        {
            if (posts.Count == 0)
            {
                Console.WriteLine("No posts available.");
            }
            else
            {
                Console.WriteLine("Posts:");
                foreach (var post in posts)
                {
                    Console.WriteLine(post);
                }
            }
        }
    }
}
