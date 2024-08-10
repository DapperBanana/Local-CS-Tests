
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("sample.txt");
        
        string emailPattern = @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}\b";
        Regex regex = new Regex(emailPattern, RegexOptions.IgnoreCase);
        
        MatchCollection matches = regex.Matches(text);
        
        Console.WriteLine("Email addresses found in the text document:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
