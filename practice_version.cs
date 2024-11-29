
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "emails.txt";

        string text = File.ReadAllText(filePath);

        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";

        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

        List<string> emailAddresses = new List<string>();

        foreach (Match match in matches)
        {
            emailAddresses.Add(match.Value);
        }

        Console.WriteLine("Email Addresses found in the text document:");

        foreach (string email in emailAddresses)
        {
            Console.WriteLine(email);
        }
    }
}
