
using System;

class Program
{
    static void Main()
    {
        string inputString = "hello world";
        string titleCaseString = ToTitleCase(inputString);
        
        Console.WriteLine("Original string: " + inputString);
        Console.WriteLine("Title case string: " + titleCaseString);
    }

    static string ToTitleCase(string input)
    {
        string[] words = input.Split(' ');
        string titleCaseString = "";

        foreach (string word in words)
        {
            if (string.IsNullOrEmpty(word))
            {
                titleCaseString += word + " ";
            }
            else
            {
                string firstLetter = word.Substring(0, 1).ToUpper();
                string restOfWord = word.Substring(1).ToLower();

                titleCaseString += firstLetter + restOfWord + " ";
            }
        }

        return titleCaseString.Trim();
    }
}
