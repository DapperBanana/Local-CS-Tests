
using System;

class Program
{
    static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";

        Array.Sort(strs);

        string first = strs[0];
        string last = strs[strs.Length - 1];

        int i = 0;
        while (i < first.Length && i < last.Length && first[i] == last[i])
        {
            i++;
        }

        return first.Substring(0, i);
    }

    static void Main()
    {
        string[] strings = { "flower", "flour", "fly", "flame" };

        string longestCommonPrefix = LongestCommonPrefix(strings);

        Console.WriteLine("The longest common prefix is: " + longestCommonPrefix);
    }
}
