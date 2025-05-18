
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Read the text file
        string filePath = "sample.txt";
        string text = File.ReadAllText(filePath);

        // Find and replace a specific word
        string wordToFind = "oldword";
        string wordToReplace = "newword";
        string newText = text.Replace(wordToFind, wordToReplace);

        // Write the modified text back to the file
        File.WriteAllText(filePath, newText);

        Console.WriteLine("Word '{0}' replaced with '{1}'", wordToFind, wordToReplace);
    }
}
