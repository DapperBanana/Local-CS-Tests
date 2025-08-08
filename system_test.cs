
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "file.txt";
        string findWord = "old word";
        string replaceWord = "new word";

        string content = File.ReadAllText(filePath);
        content = content.Replace(findWord, replaceWord);

        File.WriteAllText(filePath, content);

        Console.WriteLine("Word replaced successfully.");
    }
}
