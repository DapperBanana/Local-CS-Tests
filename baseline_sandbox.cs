
using System;
using System.Collections.Generic;

class Program
{
    static List<string> posts = new List<string>();
    static List<int> likes = new List<int>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Create a post");
            Console.WriteLine("2. View posts");
            Console.WriteLine("3. Like a post");
            Console.WriteLine("4. Exit");

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
                    LikePost();
                    break;
                case 4:
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreatePost()
    {
        Console.WriteLine("Enter your post:");
        string post = Console.ReadLine();
        posts.Add(post);
        likes.Add(0);
        Console.WriteLine("Post created successfully!");
    }

    static void ViewPosts()
    {
        Console.WriteLine("Posts:");
        for (int i = 0; i < posts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {posts[i]} - Likes: {likes[i]}");
        }
    }

    static void LikePost()
    {
        Console.WriteLine("Enter the post number you want to like:");
        int postNumber = Convert.ToInt32(Console.ReadLine()) - 1;
        if (postNumber >= 0 && postNumber < posts.Count)
        {
            likes[postNumber]++;
            Console.WriteLine("Post liked successfully!");
        }
        else
        {
            Console.WriteLine("Invalid post number. Please try again.");
        }
    }
}
