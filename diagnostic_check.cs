
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        double input = double.Parse(Console.ReadLine());
        
        ConvertDecimalToFraction(input);
    }

    static void ConvertDecimalToFraction(double number)
    {
        double epsilon = 1.0e-9;
        double errorMargin = 1.0e-9;
        
        double n = number;
        int sign = Math.Sign(n);
        n = Math.Abs(n);
        
        int wholeNumberPart = (int)n;
        
        double fractionPart = n - wholeNumberPart;
        
        double numerator = 0;
        double denominator = 1;
        double fraction = 1;
        
        int count = 0;
        
        while (Math.Abs(fraction - number) > errorMargin)
        {
            count++;
            
            if (fraction < number)
            {
                numerator = wholeNumberPart * denominator + numerator;
                wholeNumberPart = 0;
                n = 1 / (fractionPart - (int)fractionPart);
                
                numerator = numerator * (int)fractionPart + denominator;
                denominator = (int)numerator;
                numerator -= denominator;
                fractionPart = n;
            }
            else
            {
                fraction = numerator / denominator;
                denominator = (int)numerator + denominator;
                numerator = denominator - numerator;
            }
            
            if (denominator > 10000)
            {
                break;
            }
        }
        
        if (sign == -1)
        {
            wholeNumberPart *= -1;
        }
        
        Console.WriteLine("The fraction for the decimal number {0} is: {1}/{2}", number, wholeNumberPart, denominator);
    }
}
