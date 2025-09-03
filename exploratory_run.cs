
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        int maxLength = 0;
        string longestWord = "";

        string[] words = sentence.Split(' ');

        foreach (string word in words)
        {
            if (word.Length > maxLength)
            {
                maxLength = word.Length;
                longestWord = word;
            }
        }

        Console.WriteLine($"The length of the longest word is: {maxLength}");
        Console.WriteLine($"The longest word is: {longestWord}");
    }
}
