
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        int longestLength = 0;

        foreach (string word in words)
        {
            if (word.Length > longestLength)
            {
                longestLength = word.Length;
            }
        }

        Console.WriteLine($"The length of the longest word in the sentence is: {longestLength}");
    }
}
