
using System;

public class Program
{
    public static string LongestCommonPrefix(string[] strings)
    {
        if (strings == null || strings.Length == 0)
        {
            return "";
        }

        string prefix = strings[0];

        for (int i = 1; i < strings.Length; i++)
        {
            while (!strings[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }

        return prefix;
    }

    public static void Main()
    {
        string[] strings = { "flower", "flow", "flight" };
        string longestCommonPrefix = LongestCommonPrefix(strings);
        Console.WriteLine("Longest common prefix: " + longestCommonPrefix);
    }
}
