
using System;

class Program
{
    static void Main()
    {
        // Input the string
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        // Convert the string to title case
        string titleCase = ToTitleCase(input);
        Console.WriteLine("String in title case: " + titleCase);
    }

    static string ToTitleCase(string input)
    {
        // Split the input string into words
        string[] words = input.Split(' ');
        string result = "";

        // Loop through each word and convert to title case
        foreach (string word in words)
        {
            result += char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ";
        }

        // Trim any extra spaces and return the result
        return result.Trim();
    }
}
