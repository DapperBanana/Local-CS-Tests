
using System;
using System.Collections.Generic;

class Program
{
    static string LongestCommonPrefix(List<string> strings)
    {
        if (strings.Count == 0)
        {
            return "";
        }

        string prefix = strings[0];

        for (int i = 1; i < strings.Count; i++)
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

    static void Main()
    {
        List<string> strings = new List<string> { "flower", "flow", "flight" };
        string longestPrefix = LongestCommonPrefix(strings);

        Console.WriteLine("The longest common prefix is: " + longestPrefix);
    }
}
