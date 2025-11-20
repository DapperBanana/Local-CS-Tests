
using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the file path:");
        string filePath = Console.ReadLine();

        try
        {
            string text = File.ReadAllText(filePath);
            int wordCount = CountWords(text);

            Console.WriteLine($"The number of words in the file is: {wordCount}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please try again.");
        }
    }

    static int CountWords(string text)
    {
        int wordCount = 0;

        foreach (string word in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            wordCount++;
        }

        return wordCount;
    }
}
