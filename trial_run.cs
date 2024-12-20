
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        string wordToReplace = "oldWord";
        string newWord = "newWord";

        string fileContent = File.ReadAllText(filePath);
        fileContent = fileContent.Replace(wordToReplace, newWord);

        File.WriteAllText(filePath, fileContent);

        Console.WriteLine("Word replaced successfully.");
    }
}
