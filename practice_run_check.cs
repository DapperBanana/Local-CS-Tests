
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        int maxLength = 0;

        foreach (string word in words)
        {
            int length = word.Length;
            if (length > maxLength)
            {
                maxLength = length;
            }
        }

        Console.WriteLine($"The length of the longest word in the sentence is: {maxLength}");
    }
}
