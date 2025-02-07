
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "text_document.txt";
        string text = File.ReadAllText(filePath);

        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

        Console.WriteLine("Email addresses found in the text document:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
