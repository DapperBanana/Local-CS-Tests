
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Read the text file
        string filePath = "sample.txt";
        string text = File.ReadAllText(filePath);

        // Split the text into words
        char[] delimiters = new char[] { ' ', '\r', '\n' };
        string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        // Count the number of words
        int wordCount = words.Length;

        // Display the result
        Console.WriteLine("Number of words in the text file: " + wordCount);
    }
}
