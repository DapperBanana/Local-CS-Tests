
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("textfile.txt");

        string[] emailAddresses = ExtractEmailAddresses(text);

        foreach (string email in emailAddresses)
        {
            Console.WriteLine(email);
        }
    }

    static string[] ExtractEmailAddresses(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b");

        string[] emails = new string[matches.Count];

        for (int i = 0; i < matches.Count; i++)
        {
            emails[i] = matches[i].Value;
        }

        return emails;
    }
}
