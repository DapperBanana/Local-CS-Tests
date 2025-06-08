
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        int maxLength = 0;
        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            if (word.Length > maxLength)
            {
                maxLength = word.Length;
            }
        }

        Console.WriteLine($"The length of the longest word in the sentence is: {maxLength}");
    }
}
