
using System;
using System.Text.RegularExpressions;
using System.IO;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("input.txt");
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
