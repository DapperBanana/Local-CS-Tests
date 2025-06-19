
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to convert to title case:");
        string input = Console.ReadLine();

        string titleCase = ConvertToTitleCase(input);
        
        Console.WriteLine("Title case conversion: " + titleCase);
    }

    static string ConvertToTitleCase(string input)
    {
        string result = "";
        string[] words = input.Split(' ');
        
        foreach (string word in words)
        {
            string titleWord = char.ToUpper(word[0]) + word.Substring(1).ToLower();
            result += titleWord + " ";
        }
        
        return result.Trim();
    }
}
