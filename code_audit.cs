
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        List<string> emails = ExtractEmails(inputFilePath);

        foreach (string email in emails)
        {
            Console.WriteLine(email);
        }

        File.WriteAllLines(outputFilePath, emails);
    }

    static List<string> ExtractEmails(string filePath)
    {
        List<string> emails = new List<string>();

        string text = File.ReadAllText(filePath);
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            emails.Add(match.Value);
        }

        return emails;
    }
}
