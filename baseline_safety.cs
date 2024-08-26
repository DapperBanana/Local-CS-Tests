
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        string text = File.ReadAllText(filePath);

        int wordCount = CountWords(text);

        Console.WriteLine($"Number of words in the text file: {wordCount}");
    }

    static int CountWords(string text)
    {
        int wordCount = 0;

        string[] words = text.Split(new char[] { ' ', '.', ',', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        wordCount = words.Length;

        return wordCount;
    }
}
