
using System;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "world";

        Console.WriteLine("Common characters between '{0}' and '{1}':", str1, str2);

        foreach (char c in FindCommonCharacters(str1, str2))
        {
            Console.WriteLine(c);
        }
    }

    static string FindCommonCharacters(string str1, string str2)
    {
        string commonChars = "";

        foreach (char c in str1)
        {
            if (str2.Contains(c) && !commonChars.Contains(c))
            {
                commonChars += c;
            }
        }

        return commonChars;
    }
}
