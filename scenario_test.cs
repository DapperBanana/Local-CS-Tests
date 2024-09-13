
using System;

class LongestWordLength
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        int maxLength = 0;
        string[] words = sentence.Split(' ');

        foreach (string word in words)
        {
            if (word.Length > maxLength)
            {
                maxLength = word.Length;
            }
        }

        Console.WriteLine("The length of the longest word in the sentence is: " + maxLength);
    }
}
