
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "sample.txt";
            string text = File.ReadAllText(filePath);
            int wordCount = CountWords(text);
            Console.WriteLine("Number of words in the text file: " + wordCount);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }
    }

    static int CountWords(string text)
    {
        int count = 0;
        bool inWord = false;

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                if (!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }

        return count;
    }
}
