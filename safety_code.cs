
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Specify the path to the text file
        string path = "sample.txt";

        // Read the text file
        string text = File.ReadAllText(path);

        // Split the text into words based on whitespace characters
        string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        // Count the number of words
        int wordCount = words.Length;

        // Print the number of words
        Console.WriteLine($"The number of words in the text file is: {wordCount}");
    }
}
