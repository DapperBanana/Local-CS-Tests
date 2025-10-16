
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to convert to title case:");
        string inputString = Console.ReadLine();
        
        string titleCaseString = ToTitleCase(inputString);
        
        Console.WriteLine("Title Case String: " + titleCaseString);
    }
    
    static string ToTitleCase(string str)
    {
        string result = "";
        
        if (!string.IsNullOrWhiteSpace(str))
        {
            string[] words = str.Split(' ');
            
            foreach (string word in words)
            {
                result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
            }
            
            // Remove trailing white space
            result = result.Trim();
        }
        
        return result;
    }
}
