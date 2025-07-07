
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Read text file
        string text = File.ReadAllText("textfile.txt");

        // Count words
        int wordCount = CountWords(text);

        // Display result
        Console.WriteLine($"Number of words in the text file: {wordCount}");
    }

    static int CountWords(string text)
    {
        int wordCount = 0;
        bool inWord = false;

        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                inWord = true;
            }
            else
            {
                if (inWord)
                {
                    wordCount++;
                    inWord = false;
                }
            }
        }

        // Check for last word in text
        if (inWord)
        {
            wordCount++;
        }

        return wordCount;
    }
}
