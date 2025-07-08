
using System;

class Program
{
    static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }

        Array.Sort(strs);
        string first = strs[0];
        string last = strs[strs.Length - 1];

        int minLength = Math.Min(first.Length, last.Length);
        int i = 0;
        while (i < minLength && first[i] == last[i])
        {
            i++;
        }

        return first.Substring(0, i);
    }

    static void Main()
    {
        string[] strings = { "flower", "flow", "flight" };
        string longestCommonPrefix = LongestCommonPrefix(strings);

        Console.WriteLine("Longest Common Prefix: " + longestCommonPrefix);
    }
}
