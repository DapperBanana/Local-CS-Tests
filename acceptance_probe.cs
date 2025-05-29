
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "file.txt"; // Add your file path here
        string wordToFind = "oldWord";
        string replacementWord = "newWord";

        string text = File.ReadAllText(filePath);

        if (text.Contains(wordToFind))
        {
            text = text.Replace(wordToFind, replacementWord);
            File.WriteAllText(filePath, text);
            Console.WriteLine("Word replaced successfully.");
        }
        else
        {
            Console.WriteLine("Word not found in the text file.");
        }
    }
}
