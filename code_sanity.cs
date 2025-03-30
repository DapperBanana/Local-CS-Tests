
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        string text = File.ReadAllText(filePath);
        int wordCount = CountWords(text);

        Console.WriteLine($"The number of words in the text file is: {wordCount}");
    }

    static int CountWords(string text)
    {
        int wordCount = 0;
        bool isWord = false;

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                isWord = true;
            }
            else
            {
                if (isWord)
                    wordCount++;
                isWord = false;
            }
        }

        if (isWord)
            wordCount++;

        return wordCount;
    }
}
