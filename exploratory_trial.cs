using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = "Hello, World! This is a test: does it work?";
        string result = RemovePunctuation(input);
        Console.WriteLine(result);
    }

    static string RemovePunctuation(string text)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in text)
        {
            if (!char.IsPunctuation(c))
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}