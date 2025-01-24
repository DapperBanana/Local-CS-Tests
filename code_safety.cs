
using System;

class MainClass {
    public static void Main (string[] args) {
        string[] words = {"apple", "applesauce", "application"};
        string longestCommonPrefix = FindLongestCommonPrefix(words);
        
        Console.WriteLine("Longest common prefix: " + longestCommonPrefix);
    }
    
    public static string FindLongestCommonPrefix(string[] words) {
        if (words.Length == 0) return "";
        
        string prefix = words[0];
        
        for (int i = 1; i < words.Length; i++) {
            while (words[i].IndexOf(prefix) != 0) {
                prefix = prefix.Substring(0, prefix.Length - 1);
                
                if (prefix.Length == 0) return "";
            }
        }
        
        return prefix;
    }
}
