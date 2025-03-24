
using System;
using System.Text;

class Program
{
    static void Main()
    {
        string inputString = "Hello! How are you? I am doing well, thank you.";

        string result = RemovePunctuation(inputString);

        Console.WriteLine("Original String:");
        Console.WriteLine(inputString);
        Console.WriteLine("\nString with Punctuation Removed:");
        Console.WriteLine(result);
    }

    static string RemovePunctuation(string input)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            if (!char.IsPunctuation(c))
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
