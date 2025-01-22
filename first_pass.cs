
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Provide the path to the text file
        string filePath = "path_to_your_text_file.txt";

        // Read the text file
        string text = File.ReadAllText(filePath);

        // Split the text into words using whitespace as delimiter
        string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' },
            StringSplitOptions.RemoveEmptyEntries);

        // Count the number of words
        int wordCount = words.Length;

        Console.WriteLine($"Number of words in the text file: {wordCount}");
    }
}
