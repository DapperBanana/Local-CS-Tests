
using System;

class PerfectDigitalInvariantChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is a perfect digital invariant:");
        string input = Console.ReadLine();

        int number;
        if (Int32.TryParse(input, out number))
        {
            if (IsPerfectDigitalInvariant(number))
            {
                Console.WriteLine($"{number} is a perfect digital invariant.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect digital invariant.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static bool IsPerfectDigitalInvariant(int number)
    {
        int sum = 0;
        int product = 1;

        string numberStr = number.ToString();

        foreach (char digit in numberStr)
        {
            int digitValue = (int)Char.GetNumericValue(digit);
            sum += digitValue;
            product *= digitValue;
        }

        return sum * product == number;
    }
}
