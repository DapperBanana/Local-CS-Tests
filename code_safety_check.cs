
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "textfile.txt";
        string searchText = "oldWord";
        string replaceText = "newWord";

        string text = File.ReadAllText(filePath);
        text = text.Replace(searchText, replaceText);

        File.WriteAllText(filePath, text);

        Console.WriteLine("Word replaced successfully!");
    }
}
