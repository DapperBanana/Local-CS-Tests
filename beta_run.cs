
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        int longestWordLength = FindLongestWordLength(sentence);

        Console.WriteLine($"The length of the longest word in the sentence is: {longestWordLength}");
    }

    static int FindLongestWordLength(string sentence)
    {
        string[] words = sentence.Split(' ');
        int longestLength = 0;

        foreach (string word in words)
        {
            int length = word.Length;
            if (length > longestLength)
            {
                longestLength = length;
            }
        }

        return longestLength;
    }
}
