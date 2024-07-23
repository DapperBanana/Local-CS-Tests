
using System;

class Program
{
    static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        if (strs.Length == 1)
            return strs[0];

        Array.Sort(strs);

        string first = strs[0];
        string last = strs[strs.Length - 1];
        int i = 0;
        int minLength = Math.Min(first.Length, last.Length);

        while (i < minLength && first[i] == last[i])
        {
            i++;
        }

        return first.Substring(0, i);
    }

     public static void Main(string[] args)
     {
        string[] words = { "flower", "flow", "flight" };
        string result = LongestCommonPrefix(words);

        Console.WriteLine("Longest common prefix is: " + result);
     }
}
