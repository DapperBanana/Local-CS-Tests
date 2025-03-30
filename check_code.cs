
using System;

class Program
{
    static void Main()
    {
        double decimalNumber;
        
        Console.Write("Enter a decimal number: ");
        decimalNumber = Convert.ToDouble(Console.ReadLine());
        
        ConvertToFraction(decimalNumber);
    }

    static void ConvertToFraction(double decimalNumber)
    {
        double tolerance = 0.0001;
        double precision = 1.0 / tolerance;
        
        int number = (int)(decimalNumber * precision);
        int denominator = (int)precision;

        while (number % 2 == 0 && denominator % 2 == 0)
        {
            number /= 2;
            denominator /= 2;
        }
        
        Console.WriteLine($"The fraction is: {number}/{denominator}");
    }
}
