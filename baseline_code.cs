
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "sample.txt"; // Path to the text file
        
        try
        {
            string text = File.ReadAllText(path);
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;
            
            Console.WriteLine("Number of words in the text file: " + wordCount);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
