
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        string titleCase = ToTitleCase(input);
        
        Console.WriteLine("Title Case Output:");
        Console.WriteLine(titleCase);
    }
    
    static string ToTitleCase(string str)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(str.ToLower());
    }
}
