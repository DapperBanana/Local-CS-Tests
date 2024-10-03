
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        int wordCount = CountWords(filePath);

        Console.WriteLine($"Number of words in the text file: {wordCount}");
    }

    static int CountWords(string filePath)
    {
        int wordCount = 0;

        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
            }
        }

        return wordCount;
    }
}
