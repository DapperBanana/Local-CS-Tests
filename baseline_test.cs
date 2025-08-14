
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Hello, this is a #sample text with #hashtags that #should be #extracted.";

        Regex regex = new Regex(@"#\w+");
        MatchCollection matches = regex.Matches(text);

        Console.WriteLine("Hashtags found in the text:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
