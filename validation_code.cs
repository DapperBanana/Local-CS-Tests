
using System;

class NumberConverter
{
    static void Main()
    {
        Console.WriteLine("Please enter the number to convert:");
        string number = Console.ReadLine();
        
        Console.WriteLine("Please enter the base of the number (e.g. 2 for binary, 10 for decimal):");
        int fromBase = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter the base to convert the number to:");
        int toBase = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine($"Converted number: {ConvertToBase(number, fromBase, toBase)}");
    }
    
    static string ConvertToBase(string number, int fromBase, int toBase)
    {
        int decimalNumber = Convert.ToInt32(number, fromBase);
        return Convert.ToString(decimalNumber, toBase);
    }
}
