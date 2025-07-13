
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        string wordToReplace = "oldWord";
        string replacementWord = "newWord";

        // Read the text file
        string text = File.ReadAllText(filePath);

        // Find and replace the specific word
        text = text.Replace(wordToReplace, replacementWord);

        // Write the modified text back to the file
        File.WriteAllText(filePath, text);

        Console.WriteLine("Word replaced successfully!");
    }
}
