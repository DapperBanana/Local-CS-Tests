
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        string oldWord = "old";
        string newWord = "new";

        try
        {
            string text = File.ReadAllText(filePath);
            text = text.Replace(oldWord, newWord);
            File.WriteAllText(filePath, text);
            Console.WriteLine("Word replaced successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
