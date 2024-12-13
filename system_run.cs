
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputString = "Hello, World! This is a test string.";

        // Remove all non-alphanumeric characters from the input string
        string resultString = Regex.Replace(inputString, @"[^\w\s]", "");

        Console.WriteLine("Input string: " + inputString);
        Console.WriteLine("String without punctuation: " + resultString);
    }
}
