
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt"; // Path to the text file

        try
        {
            string text = File.ReadAllText(filePath); // Read all text from the file
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries); // Split text into words

            int wordCount = words.Length; // Count the number of words

            Console.WriteLine("Number of words in the text file: " + wordCount);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
