
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        string wordToReplace = "old word";
        string newWord = "new word";

        string text = File.ReadAllText(filePath);

        text = text.Replace(wordToReplace, newWord);

        File.WriteAllText(filePath, text);

        Console.WriteLine("Word replaced successfully!");
    }
}
