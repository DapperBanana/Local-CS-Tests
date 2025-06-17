
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        string wordToFind = "oldWord";
        string replacementWord = "newWord";

        string text = File.ReadAllText(filePath);

        text = text.Replace(wordToFind, replacementWord);

        File.WriteAllText(filePath, text);

        Console.WriteLine("Word replaced successfully.");
    }
}
