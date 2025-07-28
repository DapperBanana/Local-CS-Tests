
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, World!";
        
        string result = RemovePunctuation(input);
        
        Console.WriteLine(result); // Output: Hello World
    }
    
    static string RemovePunctuation(string input)
    {
        return Regex.Replace(input, @"[\p{P}-[']]|['.]", ""); // Use regex to remove all punctuation except apostrophes and periods
    }
}
