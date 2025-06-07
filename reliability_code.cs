
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the text file
        string filePath = "sample.txt";

        // Read the contents of the text file
        string text = File.ReadAllText(filePath);

        // Split the text into words based on whitespace
        string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        // Display the number of words in the text file
        Console.WriteLine($"Number of words in the text file: {words.Length}");
    }
}
