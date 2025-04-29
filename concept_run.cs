
using System;

class BaseConverter
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        string number = Console.ReadLine();
        
        Console.WriteLine("Enter the base of the number (e.g. 2 for binary, 10 for decimal):");
        int baseFrom = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the base to convert to:");
        int baseTo = int.Parse(Console.ReadLine());
        
        int decimalNumber = ConvertToDecimal(number, baseFrom);
        string convertedNumber = ConvertFromDecimal(decimalNumber, baseTo);
        
        Console.WriteLine($"Converted number is: {convertedNumber}");
    }
    
    static int ConvertToDecimal(string number, int baseFrom)
    {
        int decimalNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            decimalNumber += int.Parse(number[number.Length - i - 1].ToString()) * (int)Math.Pow(baseFrom, i);
        }
        return decimalNumber;
    }
    
    static string ConvertFromDecimal(int decimalNumber, int baseTo)
    {
        string convertedNumber = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % baseTo;
            convertedNumber = remainder.ToString() + convertedNumber;
            decimalNumber /= baseTo;
        }
        return convertedNumber;
    }
}
