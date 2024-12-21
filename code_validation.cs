
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        string findWord = "old";
        string replaceWord = "new";

        string text = File.ReadAllText(filePath);

        // Find and replace the word
        text = text.Replace(findWord, replaceWord);

        File.WriteAllText(filePath, text);

        Console.WriteLine("Word replaced successfully.");
    }
}
