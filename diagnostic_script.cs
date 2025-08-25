
using System;
using System.Collections.Generic;

class MainClass {
    public static void Main (string[] args) {
        List<string> strings = new List<string> { "flower", "flow", "flight" };

        string longestCommonPrefix = FindLongestCommonPrefix(strings);
        
        Console.WriteLine("Longest common prefix: " + longestCommonPrefix);
    }

    public static string FindLongestCommonPrefix(List<string> strings) {
        if (strings.Count == 0) {
            return "";
        }

        string prefix = strings[0];

        foreach (string str in strings) {
            while (str.IndexOf(prefix) != 0) {
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }
        
        return prefix;
    }
}
