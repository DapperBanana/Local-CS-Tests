
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("textfile.txt");

        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        
        Regex regex = new Regex(emailPattern);
        MatchCollection matches = regex.Matches(text);

        Console.WriteLine("Email Addresses found in the text document:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
