
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        string titleCase = ToTitleCase(input);
        
        Console.WriteLine("Title case: " + titleCase);
    }
    
    static string ToTitleCase(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return string.Empty;
        }
        
        string titleCase = text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();
        
        return titleCase;
    }
}
