
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "sample.txt"; // Path to the text file
            string text = File.ReadAllText(filePath);

            int wordCount = CountWords(text);

            Console.WriteLine($"Number of words in the file: {wordCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static int CountWords(string text)
    {
        int wordCount = 0;
        bool inWord = false;

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                if (!inWord)
                {
                    wordCount++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }

        return wordCount;
    }
}

