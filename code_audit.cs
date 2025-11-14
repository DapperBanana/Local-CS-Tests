
using System;

class Program
{
    static void Main()
    {
        string[] strings = { "flower", "flow", "flight" };
        string commonPrefix = LongestCommonPrefix(strings);
        
        Console.WriteLine($"Longest common prefix: {commonPrefix}");
    }

    static string LongestCommonPrefix(string[] strings)
    {
        if (strings.Length == 0) return "";
        
        Array.Sort(strings);
        
        string first = strings[0];
        string last = strings[strings.Length - 1];
        
        int i = 0;
        while (i < first.Length && i < last.Length && first[i] == last[i])
        {
            i++;
        }
        
        return first.Substring(0, i);
    }
}
