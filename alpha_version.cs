
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> posts = new List<string>();
        
        Console.WriteLine("Welcome to our Social Media Platform!");

        while (true)
        {
            Console.WriteLine("\n1. Create a new post");
            Console.WriteLine("2. View all posts");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter your post: ");
                    string newPost = Console.ReadLine();
                    posts.Add(newPost);
                    break;

                case 2:
                    Console.WriteLine("\nAll Posts:");
                    foreach (string post in posts)
                    {
                        Console.WriteLine(post);
                    }
                    break;

                case 3:
                    Console.WriteLine("Thank you for using our Social Media Platform!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
