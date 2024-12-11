
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string titleCaseString = ToTitleCase(input);
        
        Console.WriteLine("String in title case: " + titleCaseString);
    }
    
    static string ToTitleCase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (string.IsNullOrEmpty(words[i]))
                continue;
            
            char firstLetter = char.ToUpper(words[i][0]);
            string restOfWord = words[i].Substring(1).ToLower();
            words[i] = firstLetter + restOfWord;
        }

        return string.Join(" ", words);
    }
}
