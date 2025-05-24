
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt"; // Replace this with the path to your text file
        
        try
        {
            string text = File.ReadAllText(filePath);
            int wordCount = CountWords(text);
            
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
    
    static int CountWords(string text)
    {
        int wordCount = 0;
        bool lastCharWasLetter = false;
        
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                lastCharWasLetter = true;
            }
            else
            {
                if (lastCharWasLetter)
                {
                    wordCount++;
                }
                
                lastCharWasLetter = false;
            }
        }
        
        if (lastCharWasLetter)
        {
            wordCount++;
        }
        
        return wordCount;
    }
}
