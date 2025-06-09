
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputText = "This is a sample #text with #hashtags #CSharpProgram";
        
        Regex regex = new Regex(@"#\w+");
        MatchCollection matches = regex.Matches(inputText);
        
        Console.WriteLine("Extracted hashtags:");

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
