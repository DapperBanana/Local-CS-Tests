
using System;

class Program
{
    static void Main()
    {
        string[] strings = { "flower", "flow", "flight" };

        string result = LongestCommonPrefix(strings);
        
        Console.WriteLine("Longest common prefix: " + result);
    }

    static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        
        Array.Sort(strs);
        
        string first = strs[0];
        string last = strs[strs.Length - 1];

        int i = 0;
        while (i < first.Length && first[i] == last[i])
        {
            i++;
        }

        return first.Substring(0, i);
    }
}
