
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "textfile.txt";

        try
        {
            // Read the contents of the text file
            string text = File.ReadAllText(fileName);

            // Split the text by whitespace to get an array of words
            string[] words = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Count the number of words
            int wordCount = words.Length;

            Console.WriteLine($"Number of words in the text file: {wordCount}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{fileName}' not found");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}
