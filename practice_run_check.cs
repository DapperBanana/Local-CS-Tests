
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "I love #coding and #programming! #CSharp is my favorite language.";
        
        string pattern = @"#\w+";
        
        MatchCollection matches = Regex.Matches(text, pattern);
        
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
