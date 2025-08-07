
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the text file
        string filePath = "textfile.txt";

        // Read the content of the text file
        string text = File.ReadAllText(filePath);

        // Word to find and replace
        string wordToFind = "old_word";
        string replacementWord = "new_word";

        // Find and replace the word in the text
        string newText = text.Replace(wordToFind, replacementWord);

        // Write the updated text back to the text file
        File.WriteAllText(filePath, newText);

        Console.WriteLine("Word replaced successfully!");
    }
}
