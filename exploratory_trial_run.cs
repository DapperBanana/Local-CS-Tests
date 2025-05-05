
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number to convert: ");
        string number = Console.ReadLine();

        Console.WriteLine("Enter the base of the number (e.g. 2 for binary, 10 for decimal): ");
        int fromBase = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the base to convert to (e.g. 2 for binary, 10 for decimal): ");
        int toBase = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertBase(number, fromBase, toBase));
    }

    static string ConvertBase(string number, int fromBase, int toBase)
    {
        int base10 = Convert.ToInt32(number, fromBase);
        return Convert.ToString(base10, toBase);
    }
}
