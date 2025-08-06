
using System;

class LongestWordLength
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        int maxLength = 0;

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
