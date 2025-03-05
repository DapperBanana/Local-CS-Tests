
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        string wordToReplace = "oldWord";
        string newWord = "newWord";

        string text = File.ReadAllText(filePath);

        text = text.Replace(wordToReplace, newWord);

        File.WriteAllText(filePath, text);

        Console.WriteLine("Word replaced successfully.");
    }
}
