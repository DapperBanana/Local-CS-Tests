
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a #sample text with #hashtags #csharp";

        Regex regex = new Regex(@"(?<=#)\w+");

        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            Console.WriteLine("#" + match.Value);
        }
    }
}
