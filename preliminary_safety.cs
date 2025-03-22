
using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the path to the text file:");
        string filePath = Console.ReadLine();

        Console.WriteLine("Enter the word to find:");
        string wordToFind = Console.ReadLine();

        Console.WriteLine("Enter the word to replace it with:");
        string replacementWord = Console.ReadLine();

        try
        {
            string text = File.ReadAllText(filePath);

            text = text.Replace(wordToFind, replacementWord);

            File.WriteAllText(filePath, text);

            Console.WriteLine("Word replaced successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
