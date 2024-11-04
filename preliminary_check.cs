
using System;

class MainClass {
    public static string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";

        Array.Sort(strs);
        
        string first = strs[0];
        string last = strs[strs.Length - 1];
        int minLength = Math.Min(first.Length, last.Length);
        int i = 0;
        
        while (i < minLength && first[i] == last[i]) {
            i++;
        }
        
        return first.Substring(0, i);
    }

    public static void Main (string[] args) {
        string[] strs = {"flower", "flow", "flight"};
        string longestCommonPrefix = LongestCommonPrefix(strs);
        
        Console.WriteLine("Longest common prefix: " + longestCommonPrefix);
    }
}
