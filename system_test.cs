
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt"; // Change this to the path of your text file

        try
        {
            string text = File.ReadAllText(filePath);
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            Console.WriteLine($"Number of words in the file: {wordCount}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
