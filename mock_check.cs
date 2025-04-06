
using System;

class Program
{
    static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        for (int i = 0; i < strs[0].Length; i++)
        {
            char c = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[j][i] != c)
                {
                    return strs[0].Substring(0, i);
                }
            }
        }

        return strs[0];
    }

    static void Main()
    {
        string[] strings = { "flower", "flow", "flight" };
        string result = LongestCommonPrefix(strings);

        Console.WriteLine("Longest common prefix: " + result);
    }
}
