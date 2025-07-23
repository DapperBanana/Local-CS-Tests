
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfectDigitalInvariant(number))
        {
            Console.WriteLine($"{number} is a perfect digital invariant.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect digital invariant.");
        }
    }

    static bool IsPerfectDigitalInvariant(int number)
    {
        string numString = number.ToString();

        int sum = 0;
        foreach (char digit in numString)
        {
            int digitValue = int.Parse(digit.ToString());
            sum += digitValue;
        }

        return number * sum == int.Parse(numString);
    }
}
