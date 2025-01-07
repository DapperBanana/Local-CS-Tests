
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "world";

        var commonChars = str1.Intersect(str2);

        Console.WriteLine("Common characters between '{0}' and '{1}': {2}",
            str1, str2, string.Join(", ", commonChars));
    }
}
