
using System;

class MainClass {
    public static string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) {
            return "";
        }

        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++) {
            while (strs[i].IndexOf(prefix) != 0) {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrEmpty(prefix)) {
                    return "";
                }
            }
        }

        return prefix;
    }

    public static void Main(string[] args) {
        string[] strs = {"flower", "flow", "flight"};
        string longestCommonPrefix = LongestCommonPrefix(strs);
        Console.WriteLine("Longest common prefix: " + longestCommonPrefix);
    }
}
