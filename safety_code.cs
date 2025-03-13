
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        double decimalNumber = Convert.ToDouble(Console.ReadLine());

        double epsilon = 0.0001;
        double error = 1;
        double numerator = 1;
        double denominator = 1;

        while (error > epsilon)
        {
            if (decimalNumber > (numerator / denominator))
            {
                denominator++;
            }
            else if (decimalNumber < (numerator / denominator))
            {
                numerator++;
            }

            error = Math.Abs(decimalNumber - (numerator / denominator));
        }

        Console.WriteLine($"The fraction representation of {decimalNumber} is {numerator}/{denominator}");
    }
}
