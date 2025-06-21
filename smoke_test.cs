
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        int wordCount = CountWords(filePath);

        Console.WriteLine($"Number of words in the file: {wordCount}");
    }

    static int CountWords(string filePath)
    {
        string text = File.ReadAllText(filePath);
        int wordCount = 0;

        // Split the text by spaces to count words
        string[] words = text.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        wordCount = words.Length;

        return wordCount;
    }
}
