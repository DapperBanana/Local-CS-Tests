
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "textfile.txt";
        
        try
        {
            string text = File.ReadAllText(filePath);

            int wordCount = CountWords(text);

            Console.WriteLine($"The number of words in the text file is: {wordCount}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{filePath}' not found.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred while reading the file: {e.Message}");
        }
    }

    static int CountWords(string text)
    {
        int count = 0;
        bool inWord = false;

        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                if (!inWord)
                {
                    count++;
                }
                inWord = true;
            }
            else
            {
                inWord = false;
            }
        }

        return count;
    }
}
