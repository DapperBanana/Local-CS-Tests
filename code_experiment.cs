
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "This is a #sample text with #hashtags in it. #programming #csharp";

        Regex regex = new Regex(@"#\w+");

        foreach (Match match in regex.Matches(text))
        {
            Console.WriteLine(match.Value);
        }
    }
}
