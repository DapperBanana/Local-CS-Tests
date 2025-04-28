
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Input file path
        string filePath = "input.txt";

        // Read the content of the file
        string text = File.ReadAllText(filePath);

        // Word to find and replace
        string wordToReplace = "oldWord";
        string replacementWord = "newWord";

        // Replace the word in the text
        string modifiedText = text.Replace(wordToReplace, replacementWord);

        // Write the modified text back to the file
        File.WriteAllText(filePath, modifiedText);

        Console.WriteLine("Word replaced successfully.");
    }
}
