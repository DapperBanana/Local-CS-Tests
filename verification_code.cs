
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"C:\path\to\your\file.txt";
        string wordToReplace = "oldword";
        string newWord = "newword";

        // Read the file and store its content in a variable
        string fileContent = File.ReadAllText(filePath);

        // Replace the word in the content
        fileContent = fileContent.Replace(wordToReplace, newWord);

        // Write the updated content back to the file
        File.WriteAllText(filePath, fileContent);

        Console.WriteLine("Word replaced successfully!");
    }
}
