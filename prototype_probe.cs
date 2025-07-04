
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "sample.txt";
        int wordCount = 0;

        try
        {
            string text = File.ReadAllText(fileName);
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            wordCount = words.Length;
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }

        Console.WriteLine("The number of words in the file is: " + wordCount);
    }
}
