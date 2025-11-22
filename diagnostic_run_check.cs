
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string titleCase = ToTitleCase(input);

        Console.WriteLine("Title case string:");
        Console.WriteLine(titleCase);
    }

    static string ToTitleCase(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        string[] words = str.Split(' ');
        string result = "";

        foreach (string word in words)
        {
            result += char.ToUpper(word[0]) + word.Substring(1).ToLower() + " ";
        }

        return result.Trim();
    }
}
