
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Read the file path from the user
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        // Read the word to find and replace from the user
        Console.Write("Enter the word to find and replace: ");
        string wordToFind = Console.ReadLine();

        Console.Write("Enter the word to replace with: ");
        string wordToReplace = Console.ReadLine();

        // Read the content of the file
        string content = File.ReadAllText(filePath);

        // Replace the word in the content
        content = content.Replace(wordToFind, wordToReplace);

        // Write the modified content back to the file
        File.WriteAllText(filePath, content);

        Console.WriteLine("Word replaced successfully.");
    }
}
