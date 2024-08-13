
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        // Read the text document
        string text = File.ReadAllText(inputFilePath);

        // Define a regular expression for email addresses
        string pattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        Regex regex = new Regex(pattern);

        // Find all matches in the text
        MatchCollection matches = regex.Matches(text);

        // Write the email addresses to the output file
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            foreach (Match match in matches)
            {
                writer.WriteLine(match.Value);
            }
        }

        Console.WriteLine("Email addresses extracted successfully.");
    }
}
