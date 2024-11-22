
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt"; // Path to the text file

        try
        {
            // Read the text file
            string text = File.ReadAllText(filePath);

            // Split the text into words using whitespace as delimiter
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Get the count of words
            int wordCount = words.Length;

            Console.WriteLine($"Number of words in the file: {wordCount}");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while reading the file: {e.Message}");
        }
    }
}
