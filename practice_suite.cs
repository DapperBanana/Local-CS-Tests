
using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (prefix == "")
                    {
                        return "";
                    }
                }
            }

            return prefix;
        }

        static void Main(string[] args)
        {
            string[] strings = { "flower", "flow", "flight" };

            string longestCommonPrefix = LongestCommonPrefix(strings);

            Console.WriteLine("Longest Common Prefix: " + longestCommonPrefix);
        }
    }
}
