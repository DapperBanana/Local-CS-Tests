
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        string titleCaseString = ToTitleCase(input);
        
        Console.WriteLine("Result: " + titleCaseString);
    }

    static string ToTitleCase(string input)
    {
        string titleCase = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        return titleCase;
    }
}
