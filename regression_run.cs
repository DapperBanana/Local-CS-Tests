
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("sample.txt");
        string pattern = @"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+";
        
        MatchCollection matches = Regex.Matches(text, pattern);
        
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
