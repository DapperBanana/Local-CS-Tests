
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter credit card number: ");
        string input = Console.ReadLine();
        
        if (IsValidCreditCard(input))
        {
            Console.WriteLine("Valid credit card number.");
        }
        else
        {
            Console.WriteLine("Invalid credit card number.");
        }
    }
    
    static bool IsValidCreditCard(string input)
    {
        int sum = 0;
        bool doubleDigit = false;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int digit = input[i] - '0';

            if (doubleDigit)
            {
                digit *= 2;
                if (digit > 9)
                {
                    digit = digit - 9;
                }
            }

            sum += digit;
            doubleDigit = !doubleDigit;
        }

        return sum % 10 == 0;
    }
}
