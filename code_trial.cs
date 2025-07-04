
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Specify the file path
        string filePath = "sample.txt";
        
        try
        {
            // Read the contents of the file
            string text = File.ReadAllText(filePath);
            
            // Split the text by whitespace to count the words
            string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            
            // Display the number of words
            Console.WriteLine($"Number of words in the file: {words.Length}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
