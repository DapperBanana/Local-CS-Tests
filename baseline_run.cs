
using System;

class Program
{
    static void Main()
    {
        string input = "hello world";
        string titleCase = ToTitleCase(input);
        
        Console.WriteLine("Original string: " + input);
        Console.WriteLine("Title case string: " + titleCase);
    }

    static string ToTitleCase(string input)
    {
        string[] words = input.ToLower().Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                char[] letters = words[i].ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                words[i] = new string(letters);
            }
        }

        return string.Join(" ", words);
    }
}
