
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "text.txt";

        try
        {
            string text = File.ReadAllText(filePath);

            // Split the text into words
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            Console.WriteLine($"Number of words in the file: {wordCount}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error reading the file: " + e.Message);
        }
    }
}
