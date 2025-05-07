
using System;

class MainClass {
    public static void Main (string[] args) {
        string[] strings = { "flower", "flow", "flight" };

        string commonPrefix = LongestCommonPrefix(strings);

        Console.WriteLine("Longest common prefix: " + commonPrefix);
    }

    public static string LongestCommonPrefix(string[] strings) {
        if (strings.Length == 0) return "";

        string prefix = strings[0];

        for (int i = 1; i < strings.Length; i++) {
            while (strings[i].IndexOf(prefix) != 0) {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix.Length == 0) return "";
            }
        }

        return prefix;
    }
}
