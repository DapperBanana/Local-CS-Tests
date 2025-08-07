
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Provide the path to the text document
        string filePath = "sample.txt";
        
        // Read the text document
        string text = File.ReadAllText(filePath);

        // Define the regular expression pattern for email addresses
        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        
        // Match email addresses using the regular expression pattern
        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        // Print the extracted email addresses
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
