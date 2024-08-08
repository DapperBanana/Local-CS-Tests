
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "input.txt";
        string wordToReplace = "oldWord";
        string newWord = "newWord";

        if (File.Exists(filePath))
        {
            string text = File.ReadAllText(filePath);
            text = text.Replace(wordToReplace, newWord);

            File.WriteAllText(filePath, text);

            Console.WriteLine("Word replaced successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
