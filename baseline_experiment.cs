
using System;

class Program
{
    static void Main()
    {
        string[] strings = {"flower", "flo", "flight"};

        string commonPrefix = FindLongestCommonPrefix(strings);

        Console.WriteLine("The longest common prefix is: " + commonPrefix);
    }

    static string FindLongestCommonPrefix(string[] strings)
    {
        if (strings.Length == 0)
        {
            return "";
        }

        string prefix = strings[0];

        for (int i = 1; i < strings.Length; i++)
        {
            while (strings[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "")
                {
                    return "";
                }
            }
        }

        return prefix;
    }
}
