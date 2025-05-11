
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string textFilePath = "text-document.txt";

        try
        {
            string textContent = File.ReadAllText(textFilePath);

            MatchCollection matches = Regex.Matches(textContent, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b",
                RegexOptions.IgnoreCase);

            Console.WriteLine("Email addresses found in the text document:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not found: {textFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
