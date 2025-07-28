
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
        
        string newText = text.Replace(wordToReplace, newWord);
        
        File.WriteAllText(filePath, newText);
        
        Console.WriteLine("Word replaced successfully.");
    }
}
