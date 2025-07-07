
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string titleCaseString = ToTitleCase(input);
        Console.WriteLine("Title case string: " + titleCaseString);
    }

    static string ToTitleCase(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }

        string[] words = s.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }

        return string.Join(" ", words);
    }
}
