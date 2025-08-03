
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"C:\example.txt";
        string findWord = "oldWord";
        string replaceWord = "newWord";

        // Read the file content
        string text = File.ReadAllText(filePath);

        // Replace the specific word
        text = text.Replace(findWord, replaceWord);

        // Write the modified content back to the file
        File.WriteAllText(filePath, text);

        Console.WriteLine("Word replaced successfully.");
    }
}
