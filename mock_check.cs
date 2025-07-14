
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to convert to title case:");
        string input = Console.ReadLine();

        string titleCaseString = ToTitleCase(input);

        Console.WriteLine("Title case string: " + titleCaseString);
    }

    static string ToTitleCase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        string[] words = input.ToLower().Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            char[] wordChars = words[i].ToCharArray();

            if (wordChars.Length > 0)
            {
                wordChars[0] = char.ToUpper(wordChars[0]);
            }

            words[i] = new string(wordChars);
        }

        return string.Join(" ", words);
    }
}
