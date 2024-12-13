
using System;

class Program
{
    static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        
        string prefix = strs[0]; // Initialize prefix as the first string in the list
        
        for (int i = 1; i < strs.Length; i++)
        {
            // While the current string does not start with the prefix, keep shortening the prefix
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }
        
        return prefix;
    }

    static void Main()
    {
        string[] strings = { "flower", "flow", "flight" };
        string longestCommonPrefix = LongestCommonPrefix(strings);

        Console.WriteLine("Longest Common Prefix: " + longestCommonPrefix);
    }
}
