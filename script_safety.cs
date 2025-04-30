
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        decimal input = decimal.Parse(Console.ReadLine());
        
        decimal fractionPart = input % 1;
        decimal wholeNumber = input - fractionPart;
        
        decimal denominator = 1;
        while (fractionPart % 1 != 0)
        {
            fractionPart *= 10;
            denominator *= 10;
        }
        
        decimal numerator = wholeNumber * denominator + fractionPart;
        
        Console.WriteLine($"The fraction representation of {input} is {numerator}/{denominator}");
    }
}
