
using System;

class Program
{
    static string LongestCommonPrefix(string[] strings)
    {
        if (strings.Length == 0) return "";
        
        string prefix = strings[0];
        
        for (int i = 1; i < strings.Length; i++)
        {
            while (strings[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0) return "";
            }
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
