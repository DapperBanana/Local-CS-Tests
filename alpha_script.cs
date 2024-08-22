
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        string wordToFind = "oldWord";
        string replacementWord = "newWord";

        string fileContent = File.ReadAllText(filePath);
        fileContent = fileContent.Replace(wordToFind, replacementWord);

        File.WriteAllText(filePath, fileContent);

        Console.WriteLine("Word replaced successfully.");
    }
}
