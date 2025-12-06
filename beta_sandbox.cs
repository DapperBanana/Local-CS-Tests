using System;
using System.IO;

class WordCount
{
    static void Main(string[] args)
    {
        // Specify the path to the text file
        string filePath = "yourfile.txt";

        try
        {
            // Read all text from the file
            string text = File.ReadAllText(filePath);

            // Split the text into words based on whitespace characters
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Output the number of words
            Console.WriteLine($"Number of words in the file: {words.Length}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}