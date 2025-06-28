
using System;

class Program
{
    static string LongestCommonPrefix(string[] strings)
    {
        if (strings == null || strings.Length == 0)
        {
            return "";
        }

        string prefix = strings[0];
        for (int i = 1; i < strings.Length; i++)
        {
            string current = strings[i];
            int j = 0;
            while (j < prefix.Length && j < current.Length && prefix[j] == current[j])
            {
                j++;
            }
            prefix = prefix.Substring(0, j);
        }

        return prefix;
    }

    static void Main()
    {
        string[] strings = { "flower", "flow", "flight" };

        string longestCommonPrefix = LongestCommonPrefix(strings);

        Console.WriteLine("Longest common prefix: " + longestCommonPrefix);
    }
}
